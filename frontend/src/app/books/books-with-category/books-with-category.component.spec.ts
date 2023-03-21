import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BooksWithCategoryComponent } from './books-with-category.component';

describe('BooksWithCategoryComponent', () => {
  let component: BooksWithCategoryComponent;
  let fixture: ComponentFixture<BooksWithCategoryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BooksWithCategoryComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BooksWithCategoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
