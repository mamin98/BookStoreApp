import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { catchError } from 'rxjs';
import { CartService } from '../cart/service/cart.service';
import { CartPayload } from '../model/customer-cart/CartPayload';
import { environment } from 'src/environments/environment';
import { ApiPaths } from '../enums/api-paths';
import { UpdatedProductsResponse } from '../model/customer-cart/UpdatedProductsResponse';

@Component({
  selector: 'app-checkout',
  templateUrl: './checkout.component.html',
  styleUrls: ['./checkout.component.scss'],
})
export class CheckoutComponent {
  cartPayload: CartPayload = {
    customerId: 1, // to be replaced by real user ID
    cartItems: [],
  };

  purchaseActionResponse!: string;
  showImg:boolean = false;
  constructor(
    private cartService: CartService,
    private http: HttpClient,
    private router: Router
  ) {
    // update cart items from cart service ready for submitting to backend
    this.cartService.selectedCartItems$.subscribe((cartItems) => {
      this.cartPayload.cartItems = cartItems.map((item) => ({
        id: item.id,
        quantity: item.quantity,
      }));
    });
  }

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
          console.log('Checkout successful:', res.message);
          this.purchaseActionResponse = res.message;
          console.log('this.purchaseActionResponse: ', this.purchaseActionResponse);
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
