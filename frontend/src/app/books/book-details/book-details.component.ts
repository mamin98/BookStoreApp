import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CartService } from 'src/app/cart/service/cart.service';
import { CartAction } from 'src/app/constants/cart-action';
import { Book } from 'src/app/model/Book';
import { Rating } from 'src/app/model/BookRating';
import { BooksService } from '../services/books.service';

@Component({
  selector: 'app-book-details',
  templateUrl: './book-details.component.html',
  styleUrls: ['./book-details.component.scss'],
})
export class BookDetailsComponent implements OnInit {
  id: any;
  book: any = {};
  selectedQuantity: number = 0;
  stars: number = 0;
  review!: string;
  successRatingStatus!: boolean;

  constructor(
    private activRoute: ActivatedRoute,
    private bookService: BooksService,
    private cartService: CartService
  ) {
    this.id = this.activRoute.snapshot.paramMap.get('id');
  }

  ngOnInit(): void {
    this.getBookId();
    this.cartService
      .getChosenCartItemsById(Number(this.id))
      .subscribe((selected) => {
        if (selected) this.selectedQuantity = selected.quantity;
      });
  }
  getBookId() {
    this.bookService.getBooksID(this.id).subscribe((res) => {
      this.book = res;
    });
  }

  // add to card incrementing quantity by 1
  incrementQuantity = () => {
    this.selectedQuantity++;
    this.addToCart(this.book, CartAction.Increment);
  };

  // decrement item quantity from card when quantity is bigger than 1
  decrementQuantity = () => {
    if (this.selectedQuantity >= 1) {
      this.selectedQuantity--;
      this.addToCart(this.book, CartAction.Decrement);
    }
  };

  // add choosen product to card
  private addToCart = (product: Book, cartAction: CartAction) =>
    this.cartService.addToCart(product, cartAction);

  addRating(): void {
    const rating: Rating = {
      stars: this.stars,
      review: this.review,
    };
    this.bookService.addRating(this.id, rating).subscribe((data) => {
      // recall get book by id, to reflect changes
      this.getBookId();
      // clear user input upon submit
      this.stars = 0;
      this.review = '';
    });
  }

  onRatingChange(evt: Event) {
    const target = evt.target as HTMLButtonElement;
    this.stars = Number(target.value);
  }
}
