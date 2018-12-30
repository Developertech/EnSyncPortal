import { Component, OnInit } from '@angular/core';
import { EmployeeResult } from './Employee-Result-Model';
import { EmployeeResultService } from './EmployeeResultsService';

@Component({
  selector: 'employee-table',
  templateUrl: './employee.component.html'
})
export class EmployeeComponent implements OnInit {

    private sorted = false;

    private employees: EmployeeResult[] = [];

    constructor(private employeeResultsService: EmployeeResultService)
    {
        this.employeeResultsService.getAllEmployees().subscribe(res => {
            this.employees = res.json() as EmployeeResult[];
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