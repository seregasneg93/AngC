import { Employee } from './../models/employee.model';
import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EmployeesService {

  baseUrl : string = environment.baseApiUrl;

  constructor(private http: HttpClient) { }

  getAllEmployees() : Observable<Employee[]>
  {
    return this.http.get<Employee[]>(this.baseUrl + '/api/emplolyees');
  }

  addEmployee(addEmployeeRequest:Employee): Observable<Employee>{
    return this.http.post<Employee>(this.baseUrl + '/api/emplolyees',addEmployeeRequest);
  }

  getEmployee(id:string) :Observable<Employee>{
    return this.http.get<Employee>(this.baseUrl + '/api/emplolyees/' + id);
  }

  updateEmployee(id:number,updateEmployeeRequest: Employee): Observable<Employee>
  {
    return this.http.put<Employee>(this.baseUrl + '/api/emplolyees/' + id, updateEmployeeRequest);
  }

  deleteEmployee(id:number): Observable<Employee>{
    return this.http.delete<Employee>(this.baseUrl + '/api/emplolyees/' + id,);
  }
}
