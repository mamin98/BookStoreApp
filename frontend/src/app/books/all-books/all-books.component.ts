import { Component , OnInit} from '@angular/core';
import { BooksService } from '../services/books.service';

@Component({
  selector: 'app-all-books',
  templateUrl: './all-books.component.html',
  styleUrls: ['./all-books.component.scss']
})
export class AllBooksComponent implements OnInit{
books:any=[];
constructor(private booksService:BooksService){}
  ngOnInit(): void{
    this.booksService.getAllBooks().subscribe(
      data=>{
        this.books=data;
      }
    )
    // any thing return observable we can make subscribe
  }
}
