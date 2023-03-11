import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AllBooksComponent } from './books/all-books/all-books.component';
import { CartComponent } from './carts/cart/cart.component';

const routes: Routes = [
  {path:"home-allBooks",component:AllBooksComponent},
  {path:"cart",component:CartComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
