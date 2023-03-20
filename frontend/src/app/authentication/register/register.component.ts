import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UsersService } from '../service/users.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss'],
})
export class RegisterComponent implements OnInit {

  constructor(public service: UsersService,
    private router: Router) {
  }

  ngOnInit(): void {

  }

  get username() {
    return this.service.regform.get('username');
  }
  get phone() {
    return this.service.regform.get('phone');
  }
  get email() {
    return this.service.regform.get('email');
  }
  get password() {
    return this.service.regform.get('password');
  }
  get confirmpassword() {
    return this.service.regform.get('confirmpassword');
  }


  register(): void {
    var regData = this.service.regform;
    if (regData.valid) {
      console.log(regData.value);
      this.service.Register().subscribe(
        {
          next: () => {
            this.service.regform.reset();
            this.router.navigate(['login'])
          },
          error: (errMsg: any) => { console.log(errMsg?.error.message) }
        });
    }
    else {
      console.log("Form Data is Invalid.")
    }
  }

}
