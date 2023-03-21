import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { UsersService } from 'src/app/authentication/service/users.service';
import { CartService } from 'src/app/cart/service/cart.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss'],
})
export class HeaderComponent {
  selectedItemsCount$: Observable<number> =
    this.cartService.selectedItemsCount$;
  constructor(
    private cartService: CartService,
    public userService: UsersService
  ) {}
}
