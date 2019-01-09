import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-employee-action',
  templateUrl: './employee-action.component.html',
  styleUrls: ['./employee-action.component.scss']
})
export class EmployeeActionComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

  GetByEmployeeId(employeeId: number) { //TODO: Hook up the components to pass data to get the employee record
    return;
  }

  DeleteEmployee(employeeId: number) { //TODO: Hook up the components to pass data to delete
    return;
  }
}
