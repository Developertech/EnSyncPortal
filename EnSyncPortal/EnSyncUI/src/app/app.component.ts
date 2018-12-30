import { Component, OnInit } from '@angular/core';
import { EmployeeResultService } from './Employee/EmployeeResultsService';
import { EmployeeResult } from './Employee/Employee-Result-Model';
import { EmployeeComponent } from './Employee/Employee.Component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  providers: [EmployeeResultService]
})
export class AppComponent implements OnInit {

  //employees = [];
  private employees: EmployeeResult[] = [];
  
  constructor(private employeeResultsService: EmployeeResultService)
  {
   // this.employeeResultsService.getAllEmployees().subscribe(res => {
   //   this.employees = res.json() as EmployeeResult[];
   // });      
  }

  public ngOnInit() {
    
  }  
}