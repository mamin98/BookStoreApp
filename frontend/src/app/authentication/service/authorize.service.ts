import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { UsersService } from './users.service';

@Injectable({
  providedIn: 'root'
})
export class AuthorizeService implements CanActivate{

  constructor(private auth: UsersService, private router: Router) { }

  canActivate(): boolean {
    if (this.auth.isAuthenticated()) {
      return true;
    } else {
      alert("Sorry, you an unauthorized!")
      this.router.navigate(['login']);
      
      return false;
    }
  }
  
  
}
