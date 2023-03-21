import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthorizeService {

  constructor() { }

  ISloggedIn()
  {
    return !!localStorage.getItem('token');
  }
  
}
