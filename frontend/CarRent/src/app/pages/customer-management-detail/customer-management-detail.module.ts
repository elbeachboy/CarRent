import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { CustomerManagementDetailPageRoutingModule } from './customer-management-detail-routing.module';

import { CustomerManagementDetailPage } from './customer-management-detail.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    CustomerManagementDetailPageRoutingModule
  ],
  declarations: [CustomerManagementDetailPage]
})
export class CustomerManagementDetailPageModule {}
