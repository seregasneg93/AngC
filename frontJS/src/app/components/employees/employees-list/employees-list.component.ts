import { EmployeesService } from './../../../services/employees.service';
import { Employee } from './../../../models/employee.model';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-employees-list',
  templateUrl: './employees-list.component.html',
  styleUrls: ['./employees-list.component.css']
})
export class EmployeesListComponent implements OnInit {

  employees: Employee[] = [];
  empId: string = "1";
  constructor(private employeeServices: EmployeesService) { }

  ngOnInit(): void {
    this.employeeServices.getAllEmployees().subscribe(
      {
        next : (employee) =>{
          this.employees = employee;
        },
        error : (responce) =>{
          console.log(responce);
        }
      } 
    )
  }

}
