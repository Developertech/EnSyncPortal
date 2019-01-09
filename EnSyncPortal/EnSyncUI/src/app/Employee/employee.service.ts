import { Injectable } from '@angular/core';
import { ApiService } from '../api.service';

@Injectable()
export class EmployeeService {

  constructor(private api: ApiService)
  {

  }
  getAllEmployees() {
    return this.api.getAllEmployees();
  }
}
