import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AllBooksControlComponent } from './all-books-control/all-books-control.component';
import { NgxPaginationModule } from 'ngx-pagination';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

@NgModule({
  declarations: [AllBooksControlComponent],
  imports: [CommonModule, NgxPaginationModule, NgbModule],
  exports: [AllBooksControlComponent, NgxPaginationModule],
})
export class AdminModule {}
