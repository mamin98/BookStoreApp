import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Book } from 'src/app/model/Book';
import { Category } from 'src/app/model/Category';
import { AdminService } from '../services/admin.service';

@Component({
  selector: 'app-all-books-control',
  templateUrl: './all-books-control.component.html',
  styleUrls: ['./all-books-control.component.scss'],
})
export class AllBooksControlComponent {
  books: Book[] = [];

  selectedItemsCount: number = 0;
  constructor(private service: AdminService, private router: Router) {}

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
    this.service.getAllBooks().subscribe((data: Book[]) => {
      this.books = data;
      this.loading = false;
    });
  }

  // Get All Categories In Select Option
  getCategories() {
    this.loading = true; //  spinner open
    this.service.getAllCategories().subscribe((data: Category[]) => {
      this.Categories = data;
      this.loading = false; // spinner closed when
    });
  }
}
