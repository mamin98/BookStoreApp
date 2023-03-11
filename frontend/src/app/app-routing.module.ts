import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './authentication/login/login.component';
import { RegisterComponent } from './authentication/register/register.component';
import { AllBooksComponent } from './books/all-books/all-books.component';
import { CartComponent } from './carts/cart/cart.component';

const routes: Routes = [
  { path: 'home-allBooks', component: AllBooksComponent },
  { path: 'cart', component: CartComponent },
  // authentication Paths
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent },
  // authentication Paths
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
