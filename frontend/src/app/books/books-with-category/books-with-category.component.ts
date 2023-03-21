import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs';
import { Book } from 'src/app/model/Book';
import { BooksService } from '../services/books.service';

@Component({
  selector: 'app-books-with-category',
  templateUrl: './books-with-category.component.html',
  styleUrls: ['./books-with-category.component.scss'],
})
export class BooksWithCategoryComponent {
  constructor(
    private route: ActivatedRoute,
    private booksService: BooksService
  ) {}

  id!: number;
  books$!: Observable<Book[]>;
  ngOnInit() {
    this.route.params.subscribe((params) => {
      const categoryId = +params['categoryId'];
      this.id = categoryId;
      console.log('categoryId: ', categoryId);
      this.getBooksByCategory();
    });
  }
  getBooksByCategory() {
    // const res = this.booksService.getAllBooks()
    this.books$ = this.booksService.getBooksByCategory(this.id);
    // console.log('res: ', res);
  }
}
