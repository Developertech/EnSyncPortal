import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Employee.ActionComponent } from './employee.action.component';

describe('Employee.ActionComponent', () => {
  let component: Employee.ActionComponent;
  let fixture: ComponentFixture<Employee.ActionComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Employee.ActionComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Employee.ActionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
