import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { confirmPassValidator } from '../custom-validate/confirmPass.validator';
import { Login } from '../login';
import { Register } from '../register';

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  private loginPath = environment.baseApi+'account/login';
  private registerPath = environment.baseApi+'account/register';
  private profilePath = environment.baseApi+'account/profile'


  regform!: FormGroup;
  logform!: FormGroup;
  account_data: any = {};

  constructor(private http: HttpClient, private formbuilder: FormBuilder) { 
    
    // Register Form
    this.regform = this.formbuilder.group({
      username: ['', [Validators.required]],
      phone:['', [Validators.required, Validators.pattern("[0-9]{11}")]],
      email: ['', [Validators.required, Validators.pattern('[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$')]],
      password: ['', [Validators.required, Validators.pattern('^[a-zA-Z0-9_.-]*$')]],
      confirmpassword:['', Validators.required],
    },
    {validator:[confirmPassValidator]}
    );

    // Login Form
    this.logform = this.formbuilder.group({
      username: ['', [Validators.required]],
      password: ['', [Validators.required, Validators.pattern('^[a-zA-Z0-9_.-]*$')]]
    });


    // used here to call "account_data" in roleguard, header Comp 
    //  &&==> to know the current role  
    this.accountProfile().subscribe({
      next: (userData) => {
        console.log(userData);
        this.account_data = userData;
        //console.log(this.account_data);
      },
      error: (err) => {
        console.log(err?.error.message);
      }
    })
  }
  
  

  Login(): Observable<Login> {
    var jsonObj = {
      'username': this.logform.value.username,
      'password': this.logform.value.password,
    }
    return this.http.post<Login>(this.loginPath, jsonObj);
  }

  
  Register(): Observable<Register> {
    var jsonObj = {
      'username': this.regform.value.username,
      'phone': this.regform.value.phone,
      'email': this.regform.value.email,
      'password': this.regform.value.password,
      'confirmpassword': this.regform.value.confirmpassword
      
    }
    return this.http.post<Register>(this.registerPath, jsonObj);
  }


  saveToken_InLocalStorage(token: string) 
  {
    localStorage.setItem('token', token);
  }


  getToken_fromLocalStorage() 
  {
    return localStorage.getItem('token');
  }
  
  removeToken(){
    return localStorage.removeItem('token');
  }

  isAuthenticated(){
    if(this.getToken_fromLocalStorage()){
      return true;
    }else{
      return false;
    }
  }
  
  accountProfile(){
    const headers = new HttpHeaders()
    // connection-Tupe, app/json 'Bearer token' ==> like in postman
    .set('Authorization', `Bearer ${this.getToken_fromLocalStorage()}`);

    return this.http.get(this.profilePath, {headers});
  }

}
