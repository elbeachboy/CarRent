import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CustomerManagementPage } from './customer-management.page';

const routes: Routes = [
  {
    path: '',
    component: CustomerManagementPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class CustomerManagementPageRoutingModule {}
