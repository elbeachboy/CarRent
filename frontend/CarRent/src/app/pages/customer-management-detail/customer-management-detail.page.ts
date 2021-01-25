import { Component, OnInit } from '@angular/core';  
import { ActivatedRoute } from '@angular/router';  
import { Observable } from 'rxjs';
import { CustomerManagementService } from 'src/app/services/customer-management.service';

@Component({
  selector: 'app-customer-management-detail',
  templateUrl: './customer-management-detail.page.html',
  styleUrls: ['./customer-management-detail.page.scss'],
})
export class CustomerManagementDetailPage implements OnInit {

  information: Observable<any>;

  constructor(private activatedRoute : ActivatedRoute, private customerManagementService : CustomerManagementService) { }

  ngOnInit() {
    let id = this.activatedRoute.snapshot.paramMap.get('id');  
   
    this.customerManagementService.searchCustomerById(id).subscribe(result => {  
      this.information = result;  
    });  
    
  }

}
