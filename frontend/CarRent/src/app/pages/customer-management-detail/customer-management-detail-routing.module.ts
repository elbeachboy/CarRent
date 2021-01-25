import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CustomerManagementDetailPage } from './customer-management-detail.page';

const routes: Routes = [
  {
    path: '',
    component: CustomerManagementDetailPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class CustomerManagementDetailPageRoutingModule {}
