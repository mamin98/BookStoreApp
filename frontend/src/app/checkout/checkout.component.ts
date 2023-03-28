import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { catchError } from 'rxjs';
import { environment } from 'src/environments/environment';
import { CartService } from '../cart/service/cart.service';
import { ApiPaths } from '../enums/api-paths';
import { CartPayload } from '../model/customer-cart/CartPayload';
import { CartedItem } from '../model/customer-cart/CartedItem';
import { UpdatedProductsResponse } from '../model/customer-cart/UpdatedProductsResponse';

@Component({
  selector: 'app-checkout',
  templateUrl: './checkout.component.html',
  styleUrls: ['./checkout.component.scss'],
})
export class CheckoutComponent {
  successStatus: boolean = false;
  selectedCartItems!: CartedItem[];

  cartPayload: CartPayload = {
    customerId: 1, // to be replaced by real user ID
    cartItems: [],
  };

  purchaseActionResponse!: string;

  constructor(private cartService: CartService, private http: HttpClient) {
    // update cart items from cart service ready for submitting to backend
    this.cartService.getChosenCartItems().subscribe((cartItems) => {
      this.selectedCartItems = cartItems;
      this.cartPayload.cartItems = cartItems.map((item) => ({
        id: item.id,
        quantity: item.quantity,
      }));
    });
  }

  // total amount
  getTotalAmount = (cartItems: CartedItem[]) =>
    cartItems.reduce((total, item) => total + item.quantity * item.price, 0);

  confirmOrder() {
    const baseUrl = environment.baseApi;

    const url = `${baseUrl}${ApiPaths.Purchase}`;
    console.log('url: ', url);
    // confirm user orders requesting backend
    this.http
      .post<UpdatedProductsResponse>(url, this.cartPayload)
      .pipe(
        catchError((err) => {
          // if bad request (not sufficient quantity in products store), show related message
          if (err.status === 400) {
            this.purchaseActionResponse = err.error.message;
            console.log(
              `Err occured during processing purchase details: ${err.error.message}`
            );
          } else {
            console.log(
              `Err occured during fetching response data: ${err.message}`
            );
          }
          return [];
        })
      )
      .subscribe((res) => {
        if (res.success) {
          this.successStatus = true;
          console.log('Checkout successful:', res.message);
          this.purchaseActionResponse = res.message;
          console.log(
            'this.purchaseActionResponse: ',
            this.purchaseActionResponse
          );
          // clear cart after successful purchase
          this.cartService.clearCart();

          // // redirect to products page when successful
          // this.router.navigate([ApiPaths.Products]);
        } else {
          console.log('err: ', res.message);
        }
      });
  }

  // handle user navigation
  // toProductsPage = () => this.router.navigate([ApiPaths.AllBooks]);
}
