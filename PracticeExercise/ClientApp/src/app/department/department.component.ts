import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-department',
  templateUrl: './department.component.html'
})
export class DepartmentComponent {
  public departments: Department[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Department[]>(baseUrl + 'department').subscribe(result => {
      this.departments = result;
    }, error => console.error(error));
  }
}

interface Department {
  id: number;
  name: string;
}
