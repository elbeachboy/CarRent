import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: 'customer-management',
    loadChildren: () => import('./pages/customer-management/customer-management.module').then( m => m.CustomerManagementPageModule)
  },
  {
    path: '',
    redirectTo: 'customer-management',
    pathMatch: 'full'
  },
  {
    path: 'customer-management-detail/:id',
    loadChildren: () => import('./pages/customer-management-detail/customer-management-detail.module').then( m => m.CustomerManagementDetailPageModule)
  },
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
