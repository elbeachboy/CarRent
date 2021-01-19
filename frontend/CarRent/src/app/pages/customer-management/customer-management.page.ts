import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';  
import { CustomerManagementService } from 'src/app/services/customer-management.service';

@Component({
  selector: 'app-customer-management',
  templateUrl: './customer-management.page.html',
  styleUrls: ['./customer-management.page.scss'],
})
export class CustomerManagementPage implements OnInit {

  results: Observable<any>;  
  searchTerm: string = '';  

  constructor(private customerManagementService: CustomerManagementService) { }

  ngOnInit() {
  }

  livesearch() {    
    this.results = this.customerManagementService.searchCustomer(this.searchTerm);  
  }

}
