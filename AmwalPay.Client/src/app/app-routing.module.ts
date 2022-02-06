import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TransactionFormComponent } from './Modules/transaction-form/transaction-form.component';

const routes: Routes = [

  { path: '', component: TransactionFormComponent },
  { path: 'transaction/add', component:TransactionFormComponent},


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
