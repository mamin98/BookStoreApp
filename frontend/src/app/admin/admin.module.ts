import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AllBooksControlComponent } from './all-books-control/all-books-control.component';

@NgModule({
  declarations: [AllBooksControlComponent],
  imports: [CommonModule],
  exports: [AllBooksControlComponent],
})
export class AdminModule {}
