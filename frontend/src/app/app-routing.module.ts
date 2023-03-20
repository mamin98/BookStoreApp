import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './authentication/login/login.component';
import { RegisterComponent } from './authentication/register/register.component';
import { AllBooksComponent } from './books/all-books/all-books.component';
import { BookDetailsComponent } from './books/book-details/book-details.component';
import { CartComponent } from './cart/cart.component';
import { CheckoutComponent } from './checkout/checkout.component';

const routes: Routes = [
  { path: 'home-allBooks', component: AllBooksComponent },
  { path: 'bookDetails/:id', component: BookDetailsComponent },
  { path: 'cart', component: CartComponent },
  // authentication Paths
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'checkout', component: CheckoutComponent },

  // authentication Paths
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
