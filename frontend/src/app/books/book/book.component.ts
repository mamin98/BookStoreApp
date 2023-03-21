import { Component, Input } from '@angular/core';
import { CartService } from 'src/app/cart/service/cart.service';
import { CartAction } from 'src/app/enums/card-action';
import { Book } from 'src/app/model/Book';
import { BooksService } from '../services/books.service';

@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.scss'],
})
export class BookComponent {
  quantity: number = 0;

  @Input() product!: Book;
  addButton: boolean = false;
  constructor(
    private cartService: CartService,
    private booksService: BooksService
  ) {}

  // add to card incrementing quantity by 1
  incrementQuantity = () => {
    this.quantity++;
    this.addToCart(this.product);
    // notify quantity count observer for header cart update
    this.cartService.updateQuantityCount(CartAction.Increment);
  };

  // decrement item quantity from card when quantity is bigger than 1
  decrementQuantity = () => {
    if (this.quantity >= 1) {
      this.quantity--;
      this.addToCart(this.product);
      // notify quantity count observer for header cart update
      this.cartService.updateQuantityCount(CartAction.Decrement);
    }
  };

  // add choosen product to card
  addToCart = (product: Book) =>
    this.cartService.addToCart(product, this.quantity);
}
