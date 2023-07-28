import { Component, ElementRef, Input, ViewChild } from '@angular/core';
import { CartService } from 'src/app/cart/service/cart.service';
import { CartAction } from 'src/app/constants/cart-action';
import { Book } from 'src/app/model/Book';

@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.scss'],
})
export class BookComponent {
  selectedQuantity: number = 0;

  @Input() product!: Book;
  addButton: boolean = false;
  constructor(private cartService: CartService) {}
  chosenCartItems$ = this.cartService.selectedCartItems$;

  @ViewChild('cartButton') cartButton!: ElementRef;

  // add to card incrementing quantity by 1
  incrementQuantity = () => {
    this.selectedQuantity++;
    this.addToCart(this.product, CartAction.Increment);
  };

  showIncrementCount = () => {
    this.cartService
      .getChosenCartItemsById(Number(this.product.id))
      .subscribe((selected) => {
        if (selected?.quantity) {
          this.selectedQuantity = selected.quantity;
        }
      });
  };

  // decrement item quantity from card when quantity is bigger than 1
  decrementQuantity = () => {
    if (this.selectedQuantity >= 1) {
      this.selectedQuantity--;
      this.addToCart(this.product, CartAction.Decrement);
    }
  };

  // add choosen product to card only when add button is active
  addToCart = (product: Book, cartAction: CartAction) => {
    this.addButton && this.cartService.addToCart(product, cartAction);
  };
}
