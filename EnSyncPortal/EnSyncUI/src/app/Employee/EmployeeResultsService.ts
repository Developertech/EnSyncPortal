import { Injectable } from '@angular/core';
import { ApiService } from '../api.service';

@Injectable()
export class EmployeeResultService {

  constructor(private api: ApiService)
  {

  }
  getAllEmployees() {
    return this.api.getAllEmployees();
  }
}
