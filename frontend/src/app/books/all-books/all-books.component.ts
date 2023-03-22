import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Book } from 'src/app/model/Book';
import { Category } from 'src/app/model/Category';
import { BooksService } from '../services/books.service';

@Component({
  selector: 'app-all-books',
  templateUrl: './all-books.component.html',
  styleUrls: ['./all-books.component.scss'],
})
export class AllBooksComponent implements OnInit {
  selectedItemsCount: number = 0;
  constructor(private booksService: BooksService, private router: Router) {}

  books: Book[] = [];
  Categories: Category[] = [];
  addButton: boolean = false;
  cartBooks: any[] = [];
  loading: boolean = false; // this for spinner

  booksByCategory!: Book[];
  categories: any = this.getCategories();

  p: number = 1;

  ngOnInit(): void {
    this.getAllBooks();
    this.getCategories();
  }

  goToCart() {
    this.router.navigate(['/cart']);
  }

  handleSelectedCategory(event: Event) {
    const target = event.target as HTMLButtonElement;
    const categoryId = Number(target.value);
    // Navigate to books with category component with the selected id
    this.router.navigate(['/home-allBooks/categories', categoryId]);
  }

  getAllBooks() {
    this.loading = true; //  spinner open
    this.booksService.getAllBooks().subscribe((data: Book[]) => {
      this.books = data;
      this.loading = false;
    });
  }

  // Get All Categories In Select Option
  getCategories() {
    this.loading = true; //  spinner open
    this.booksService.getAllCategories().subscribe((data: Category[]) => {
      this.Categories = data;
      this.loading = false; // spinner closed when
    });
  }

  // FilterCategory(event:any){
  //   let value = event.target.value
  // console.log(value);
  // // this.getBooksCategory(value);
  // this.booksService.getBooksByCategory(value).subscribe((res:any) => {
  //   this.booksByCategory = res
  // })
  // }
}
