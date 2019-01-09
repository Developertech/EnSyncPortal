import { Component, OnInit } from '@angular/core';
import { EmployeeModel } from './employee.model';
import { EmployeeService } from './employee.service';

@Component({
  selector: 'employee-table',
  templateUrl: './employee.component.html'
})
export class EmployeeComponent implements OnInit {

    private sorted = false;

    private employees: EmployeeModel[] = [];

  constructor(private employeeResultsService: EmployeeService)
    {
        this.employeeResultsService.getAllEmployees().subscribe(res => {
            this.employees = res.json() as EmployeeModel[];
        });      
    }

    sortBy(by: string | any): void {

    this.employees.sort((a: any, b: any) => {
        if (a[by] < b[by]) {
        return this.sorted ? 1 : -1;
        }
        if (a[by] > b[by]) {
        return this.sorted ? -1 : 1;
        }

        return 0;
    });

    this.sorted = !this.sorted;
    }

    public ngOnInit() {
    
    } 
}
