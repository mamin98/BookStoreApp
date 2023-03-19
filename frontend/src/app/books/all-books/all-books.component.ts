import { Component, OnInit } from '@angular/core';
import { Category } from 'src/app/model/Category';
import { BooksService } from '../services/books.service';
import { Book } from 'src/app/model/Book';

@Component({
  selector: 'app-all-books',
  templateUrl: './all-books.component.html',
  styleUrls: ['./all-books.component.scss'],
})
export class AllBooksComponent implements OnInit {
  books: any = [];
  Categories: any = [];
  addButton: boolean = false;
  cartBooks: any[] = [];
  loading: boolean = false; // this for spinner
  constructor(private booksService: BooksService) {}

  booksByCategory!: Book[];
  categories: any = this.getCategories();

  ngOnInit(): void {
    // this.booksService.getAllBooks().subscribe(
    //   data=>{
    //     this.books=data;
    //   }
    // )
    // any thing return observable we can make subscribe
    // this.getAllBooks();
    // this.getCategories();
  }

  handleSelectedCategory(id: number) {
    console.log('works');
    let res = this.categories.find((category: Category) => {
      return category.id === id;
    }
    );
    this.booksByCategory = res.books
    console.log('this.categories: ', this.categories);
  }
   

  // getAllBooks(){
  //   this.loading = true; //  spinner open
  //   this.booksService.getAllBooks().subscribe((data:any) => {
  //     this.books  = data
  //     this.loading = false // spinner closed when
  //   })
  // }
  //Get Data from localStorage
  addToCart(event: any) {
    // console.log(event)
    // JSON.stringify() // send data
    // JSON.parse() // receive data

    if ('cart' in localStorage) {
      this.cartBooks = JSON.parse(localStorage.getItem('cart')!); //
      // if the item exist or not
      let exist = this.cartBooks.find((item) => item.item.id == event.item.id);
      if (exist) {
        alert('product is Already in your Cart');
      } else {
        //push data
        this.cartBooks.push(event);
        // send the updated array to localStorage
        localStorage.setItem('cart', JSON.stringify(this.cartBooks));
      }
    } else {
      this.cartBooks.push(event);
      localStorage.setItem('cart', JSON.stringify(this.cartBooks));
    }
  }
  //Get All Categories In Select Option
  getCategories() {
    this.loading = true; //  spinner open
    this.booksService.getAllCategories().subscribe((data: any) => {
      this.categories = data;
      // console.log('this.Categories : ', this.categories );
      this.loading = false; // spinner closed when
    });
  }


  // filter(event:any){
  //   let value = event.target.value
  //   console.log(value)
  //   this.GetBooksCategory(value)
  // }

  //GetBooksCategory After Selected
  // GetBooksCategory(id:string){
  //   this.booksService.getBooksByCategory(id).subscribe((res:any) => {
  //     this.books = res
  //   })
  // }
}
