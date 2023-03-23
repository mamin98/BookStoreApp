import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AllBooksControlComponent } from './all-books-control.component';

describe('AllBooksControlComponent', () => {
  let component: AllBooksControlComponent;
  let fixture: ComponentFixture<AllBooksControlComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AllBooksControlComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AllBooksControlComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
