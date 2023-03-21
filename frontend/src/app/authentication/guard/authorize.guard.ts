import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { AuthorizeService } from '../service/authorize.service';

@Injectable({
  providedIn: 'root'
})
export class AuthorizeGuard implements CanActivate {

  constructor(
    private auth:AuthorizeService,
     private router:Router
    ) {}
  
  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
      if(this.auth.ISloggedIn()){
        return true;
      }
      // try return to previous page, will display alert message:
      alert("You have not Logged In") 
      this.router.navigate(['login']);
  
      return false;
    }
  
}
