import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CustomValidateComponent } from './custom-validate.component';

describe('CustomValidateComponent', () => {
  let component: CustomValidateComponent;
  let fixture: ComponentFixture<CustomValidateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CustomValidateComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CustomValidateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
