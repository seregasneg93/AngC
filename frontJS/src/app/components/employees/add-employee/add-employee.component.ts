import { Router, Routes } from '@angular/router';
import { EmployeesService } from './../../../services/employees.service';
import { Employee } from './../../../models/employee.model';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.css']
})
export class AddEmployeeComponent implements OnInit {

  addEmployeeRequest : Employee =
  {
    id: 0,
    name:'',
    email:'',
    salary:0,
    phone:0,
    department:''
  };

  constructor(private employeeService:EmployeesService,private router: Router) { }

  ngOnInit(): void {
  }

  addEmployee(){
    this.employeeService.addEmployee(this.addEmployeeRequest)
      .subscribe({
        next: (employe) =>{
          this.router.navigate(['employees']);
        }
      });
  }
}
