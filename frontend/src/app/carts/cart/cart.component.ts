import { Component , OnInit} from '@angular/core';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.scss']
})
export class CartComponent implements OnInit{
  cartBooks:any[] = []

  ngOnInit(): void {
   this.getCartBooks();
  }
  getCartBooks(){
    if("cart" in localStorage){
      this.cartBooks = JSON.parse(localStorage.getItem("cart")!)
     } //
     console.log(this.cartBooks)
  }

}
