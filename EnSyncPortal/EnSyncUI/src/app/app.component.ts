import { Component, OnInit } from '@angular/core';
import { EmployeeService } from './Employee/employee.service';
import { EmployeeModel } from './Employee/employee.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  providers: [EmployeeService]
})
export class AppComponent implements OnInit {

  //employees = [];
  private employees: EmployeeModel[] = [];
  
  constructor(private employeeService: EmployeeService)
  {
    this.employeeService.getAllEmployees().subscribe(res => {
      this.employees = res.json() as EmployeeModel[];
    });      
  }

  public ngOnInit() {
    
  }  
}
