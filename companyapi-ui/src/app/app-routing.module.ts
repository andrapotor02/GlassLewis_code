import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AllCompaniesComponent } from './all-companies/all-companies.component';
import { CreateCompanyComponent } from './create-company/create-company.component';
import { UpdateCompanyComponent } from './update-company/update-company.component';
import { CompanyByIsinComponent } from './company-by-isin/company-by-isin.component';

const routes: Routes = [
  { path: 'all-companies', component: AllCompaniesComponent, title: "All Companies" },
  { path: 'create-company', component: CreateCompanyComponent, title: "Create Company" },
  { path: 'update-company', component: UpdateCompanyComponent, title: "Update Company" },
  { path: 'company-by-isin', component: CompanyByIsinComponent, title: "Get Company by Isin" }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
