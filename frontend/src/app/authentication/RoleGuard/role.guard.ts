import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { UsersService } from '../service/users.service';

@Injectable({
  providedIn: 'root'
})
export class RoleGuard implements CanActivate {
  
  isAdmin: boolean = false;
  role:string="";

  constructor(private user: UsersService){}

  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
      
      // get current tole
      this.role = this.user.account_data.role;
      if(this.role == "Administrator"){
        this.isAdmin = true;
      }

      alert("Just allowed for Admins");
      return this.isAdmin;
  }
  
}
