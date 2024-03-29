import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RouterModule } from '@angular/router';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { RatingModule } from 'ngx-bootstrap/rating';
import { NgxPaginationModule } from 'ngx-pagination';
import { AdminModule } from './admin/admin.module';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CustomValidateComponent } from './authentication/custom-validate/custom-validate.component';
import { LoginComponent } from './authentication/login/login.component';
import { RegisterComponent } from './authentication/register/register.component';
import { AllBooksComponent } from './books/all-books/all-books.component';
import { BookDetailsComponent } from './books/book-details/book-details.component';
import { BookComponent } from './books/book/book.component';
import { BooksWithCategoryComponent } from './books/books-with-category/books-with-category.component';
import { CartComponent } from './cart/cart.component';
import { FooterComponent } from './shared/footer/footer.component';
import { HeaderComponent } from './shared/header/header.component';
import { SpinnerComponent } from './shared/spinner/spinner.component';
import { CheckoutComponent } from './checkout/checkout.component';

@NgModule({
  declarations: [
    AppComponent,
    AllBooksComponent,
    BookDetailsComponent,
    HeaderComponent,
    FooterComponent,
    CartComponent,
    CheckoutComponent,
    CustomValidateComponent,
    LoginComponent,
    RegisterComponent,
    BookComponent,
    SpinnerComponent,
    BooksWithCategoryComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    HttpClientModule,
    FormsModule,
    RouterModule,
    ReactiveFormsModule,
    NgxPaginationModule,
    AdminModule,
    BrowserAnimationsModule,
    RatingModule.forRoot(),
  ],
  exports: [NgxPaginationModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
