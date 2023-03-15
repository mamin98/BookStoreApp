import { Component,EventEmitter,Input, Output } from '@angular/core';
import { EmailValidator } from '@angular/forms';

@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.scss']
})
export class BookComponent {
  @Input() data:any = {}
  //Send data from parent to chield
  @Output() item = new EventEmitter()
  addButton:boolean = false;
  amount:number = 0
  add(){
    this.item.emit({item:this.data, quantity:this.amount})
  }
}
