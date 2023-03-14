import { Component,Input } from '@angular/core';

@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.scss']
})
export class BookComponent {
  @Input() data:any = {}
  addButton:boolean = false;
  add(){

  }
}
