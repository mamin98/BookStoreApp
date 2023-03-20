import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { UsersService } from '../service/users.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
})
export class LoginComponent {

  constructor(public service: UsersService, private router: Router) { }

  get username() {
    return this.service.logform.get('username');
  }
  get password() {
    return this.service.logform.get('password');
  }

  login() {
    var loginData = this.service.logform
    if (loginData.valid) {
      console.log(loginData.value);
      this.service.Login().subscribe((data: any) => {
        console.log(data);
        this.service.SaveToken_InLocalStorage(data['token'])
        this.router.navigate(['home-allBooks'])
      }
      )
    }
  }

}
