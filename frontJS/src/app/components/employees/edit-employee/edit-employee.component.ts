import { Employee } from './../../../models/employee.model';
import { EmployeesService } from './../../../services/employees.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-edit-employee',
  templateUrl: './edit-employee.component.html',
  styleUrls: ['./edit-employee.component.css']
})
export class EditEmployeeComponent implements OnInit {

  employeeDetails: Employee = {
    id: 0,
    name:'',
    email:'',
    salary:0,
    phone:0,
    department:''
  }

  constructor(private route:ActivatedRoute,private employeeService:EmployeesService,private router:Router) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) =>{
        const id = params.get('id');

       // let id = parseInt('idConv');
        if(id)
        {
          this.employeeService.getEmployee(id)
          .subscribe({
            next: (employee) =>{
              this.employeeDetails = employee;
            }
          })
        }
      }
    })
  }

  updateEmployee(){
    this.employeeService.updateEmployee(this.employeeDetails.id,this.employeeDetails)
        .subscribe({
          next: (empl) =>{
            this.router.navigate(['employees']);
          }
        });
  }

  deleteEmployee(id:number){
    this.employeeService.deleteEmployee(id).subscribe({
      next : (empl) =>{
        this.router.navigate(['employees']);
      }
    });
  }

}
