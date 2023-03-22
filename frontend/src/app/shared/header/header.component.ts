import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { UsersService } from 'src/app/authentication/service/users.service';
import { CartService } from 'src/app/cart/service/cart.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss'],
})
export class HeaderComponent implements OnInit{

  selectedItemsCount$: Observable<number> =
    this.cartService.selectedItemsCount$;
    
    account_data: any = {};
    constructor(
    private cartService: CartService,
    public userService: UsersService
  ) {}

  ngOnInit(): void {

    this.userService.accountProfile().subscribe({
      next: (userData) => {
        //console.log(userData);
        this.account_data = userData;
        //console.log(this.account_data);
      },
      error: (err) => {
        console.log(err?.error.message);
      }
    })
  }
}
