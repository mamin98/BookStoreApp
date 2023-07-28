import { Component } from '@angular/core';
import { CartService } from '../cart/service/cart.service';
import { CartPayload } from '../model/customer-cart/CartPayload';
import { CartedProductItem } from '../model/customer-cart/CartedProductItem';
import { CheckoutService } from './service/checkout.service';

@Component({
  selector: 'app-checkout',
  templateUrl: './checkout.component.html',
  styleUrls: ['./checkout.component.scss'],
})
export class CheckoutComponent {
  successStatus!: boolean 
  orderStatus!: string
  selectedCartItems$ = this.cartService.selectedCartItems$

  purchaseActionResponse!: string;

  constructor(
    private checkoutService: CheckoutService,
    private cartService: CartService
  ) {}

  // total amount
  getTotalAmount = (cartItems: CartedProductItem[]) =>
    cartItems?.reduce((total, item) => total + item.quantity * item.price, 0);

  purchaseCart() {
    this.checkoutService.purchaseCart().subscribe((result) => {
      this.orderStatus = result.message
      this.successStatus = result.success
    })
  }
}
