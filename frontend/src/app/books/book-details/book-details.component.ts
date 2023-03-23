import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CartService } from 'src/app/cart/service/cart.service';
import { CartAction } from 'src/app/enums/card-action';
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
  quantity: number = 0;
  stars!: any;
  review!: string;
  successRatingStatus!: boolean;

  constructor(
    private activRoute: ActivatedRoute,
    private bookService: BooksService,
    private cartService: CartService
  ) {
    this.id = this.activRoute.snapshot.paramMap.get('id');
    console.log(this.id);
  }

  ngOnInit(): void {
    this.getBookId();
  }
  getBookId() {
    this.bookService.getBooksID(this.id).subscribe((res) => {
      this.book = res;
    });
  }

  // add to card incrementing quantity by 1
  incrementQuantity = () => {
    this.quantity++;
    this.addToCart(this.book);
    // notify quantity count observer for header cart update
    this.cartService.updateQuantityCount(CartAction.Increment);
  };

  // decrement item quantity from card when quantity is bigger than 1
  decrementQuantity = () => {
    if (this.quantity >= 1) {
      this.quantity--;
      this.addToCart(this.book);
      // notify quantity count observer for header cart update
      this.cartService.updateQuantityCount(CartAction.Decrement);
    }
  };

  // add choosen product to card
  private addToCart = (product: Book) =>
    this.cartService.addToCart(product, this.quantity);

  // ratingChanged(evt: Event) {}

  addRating(): void {
    const rating: Rating = {
      stars: this.stars,
      review: this.review,
    };
    this.bookService.addRating(this.id, rating).subscribe(data => {
      console.log("data ", data)
    });

    // recall get book by id, to reflect changes
    // this.getBookId()
  }

  onRatingChange(evt: Event){
    const target = evt.target as HTMLButtonElement;
    this.stars = target.value
  }
}
