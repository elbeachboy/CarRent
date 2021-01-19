import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { CustomerManagementPageRoutingModule } from './customer-management-routing.module';

import { CustomerManagementPage } from './customer-management.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    CustomerManagementPageRoutingModule
  ],
  declarations: [CustomerManagementPage]
})
export class CustomerManagementPageModule {}
