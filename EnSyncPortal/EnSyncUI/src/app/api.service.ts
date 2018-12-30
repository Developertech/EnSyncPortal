import { Injectable} from '@angular/core';
import { environment } from './environments/environments';
import { Http} from '@angular/http';

const API_URL = environment.apiUrl;

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: Http)
  {
  }

  //public getAllEmployees(): Observable<EmployeeResult> {
  //  return this.http
  //    .get(API_URL + '/api/employee').map(emp => new EmployeeResult(emp));
  //}

  public getAllEmployees() {
    return this.http
      .get(API_URL + '/api/GetAllEmployees');
  }
}
