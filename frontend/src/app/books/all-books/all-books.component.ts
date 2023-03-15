import { Component , OnInit} from '@angular/core';
import { BooksService } from '../services/books.service';

@Component({
  selector: 'app-all-books',
  templateUrl: './all-books.component.html',
  styleUrls: ['./all-books.component.scss']
})
export class AllBooksComponent implements OnInit{
books:any=[];
addButton:boolean = false;
cartBooks:any[] = []
constructor(private booksService:BooksService){}
  ngOnInit(): void{
    // this.booksService.getAllBooks().subscribe(
    //   data=>{
    //     this.books=data;
    //   }
    // )
    // any thing return observable we can make subscribe
    this.getAllBooks();

  }
  getAllBooks(){
    this.booksService.getAllBooks().subscribe((data:any) => {
      this.books  = data
    })
  }
//Get Data from LocalStoredg
  addToCart(event:any){
    // console.log(event)
    // JSON.stringify() // send data
    // JSON.parse() // receive data

    if("cart" in localStorage){
      this.cartBooks = JSON.parse(localStorage.getItem("cart")!) //
      // if the item exist or not
      let exist = this.cartBooks.find(item => item.item.id== event.item.id)
      if(exist){
        alert("product is Already in your Cart")
      } else{
              //push data
      this.cartBooks.push(event)
      // send the updated array to localStorage
      localStorage.setItem("cart", JSON.stringify(this.cartBooks))
      }
    } else{
      this.cartBooks.push(event)
      localStorage.setItem("cart", JSON.stringify(this.cartBooks))
    }

  }


}
