import { Component , OnInit} from '@angular/core';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.scss']
})
export class CartComponent implements OnInit{
  cartBooks:any[] = []
  total:any = 0
  ngOnInit(): void {
   this.getCartBooks();
  }
  getCartBooks(){
    if("cart" in localStorage){
      this.cartBooks = JSON.parse(localStorage.getItem("cart")!)
     } //
     console.log(this.cartBooks)
     this.getCartTotal();
  }
  getCartTotal(){
    this.total = 0
    for(let x in this.cartBooks)
    {
      this.total += this.cartBooks[x].item.price * this.cartBooks[x].quantity
    }
  }
}
