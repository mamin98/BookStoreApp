import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { take } from 'rxjs';
import { ApiPaths } from '../enums/api-paths';
import { CartAction } from '../enums/card-action';
import { CartedItem } from '../model/customer-cart/CartedItem';
import { CartService } from './service/cart.service';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.scss'],
})
export class CartComponent {
  quantity: number = 1;
  chosenCartItems$ = this.cartService.getChosenCartItems();

  constructor(private cartService: CartService, private router: Router) {}

  // add to card incrementing quantity by 1
  // notify updateCart func with increment type
  incrementQuantity = (item: CartedItem) =>
    this.quantity++ && this.updateCart(item, CartAction.Increment);

  // decrement item quantity from card
  // notify updateCart func with increment type
  decrementQuantity = (item: CartedItem) =>
    this.updateCart(item, CartAction.Decrement);

  updateCart(item: CartedItem, type: CartAction) {
    this.cartService
      .getChosenCartItemsById(item.id)
      .pipe(take(1))
      .subscribe((product) => {
        if (product) {
          if (type === CartAction.Increment) {
            this.cartService.addToCart(product, product.quantity + 1);
          }
          if (type === CartAction.Decrement && product.quantity > 1) {
            this.cartService.addToCart(product, product.quantity - 1);
          }
        }
      });
  }

  removeItemFromCart(item: CartedItem) {
    this.cartService.removeItemFromCart(item.id);
  }

  // clear cart
  clearCart = () => this.cartService.clearCart();

  // handle user navigation
  toProductsPage = () => this.router.navigate([ApiPaths.AllBooks]);
  toCheckoutPage = () => this.router.navigate([ApiPaths.Checkout]);
}
