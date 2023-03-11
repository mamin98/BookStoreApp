import { Component } from '@angular/core';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { confirmPassValidator } from '../custom-validate/confirmPass.validator';
import { Register } from '../register';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss'],
})
export class RegisterComponent {
  constructor(private fb: FormBuilder) {}

  regForm = this.fb.group(
    {
      username: ['', Validators.required],
      email: ['', Validators.required],
      password: ['', Validators.required],
      confirmPass: ['', Validators.required],
    },
    { validator: [confirmPassValidator] }
  );

  get username() {
    return this.regForm.get('username');
  }
  get email() {
    return this.regForm.get('email');
  }
  get password() {
    return this.regForm.get('password');
  }
  get confirmPass() {
    return this.regForm.get('confirmPass');
  }
}
