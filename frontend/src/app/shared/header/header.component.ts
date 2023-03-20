import { Component, OnInit } from '@angular/core';
import { BooksService } from 'src/app/books/services/books.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss'],
})
export class HeaderComponent implements OnInit {
  selectedCount!: number;
  constructor(private bookService: BooksService) {}

  ngOnInit(): void {
    this.bookService.selectedItemsCount$.subscribe((count) => {
      this.selectedCount = count;
      console.log('this.selectedCount: ', this.selectedCount);
    });
  }
}
