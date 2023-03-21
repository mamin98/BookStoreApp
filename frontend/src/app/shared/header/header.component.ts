import { Component, OnInit } from '@angular/core';
import { UsersService } from 'src/app/authentication/service/users.service';
import { BooksService } from 'src/app/books/services/books.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss'],
})
export class HeaderComponent implements OnInit {
  selectedCount!: number;
  constructor(private bookService: BooksService, public userService: UsersService) {}

  ngOnInit(): void {
    this.bookService.selectedItemsCount$.subscribe((count) => {
      this.selectedCount = count;
      console.log('this.selectedCount: ', this.selectedCount);
    });
  }
}
