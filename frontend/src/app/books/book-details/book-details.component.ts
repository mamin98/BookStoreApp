import { Component ,OnInit} from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BooksService } from '../services/books.service';

@Component({
  selector: 'app-book-details',
  templateUrl: './book-details.component.html',
  styleUrls: ['./book-details.component.scss']
})
export class BookDetailsComponent implements OnInit {

  id:any;
  book:any = {};
  constructor(private activRoute:ActivatedRoute,private bookService:BooksService){
    this.id = this.activRoute.snapshot.paramMap.get("id")
    console.log(this.id)
  }

ngOnInit(): void {
    this.getBookId();
}
  getBookId(){
    this.bookService.getBooksID(this.id).subscribe(res => {
      this.book = res
    })
  }
}
