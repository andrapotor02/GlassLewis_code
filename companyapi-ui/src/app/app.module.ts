import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CompanyService } from './company.service';
import { provideHttpClient } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { SiteHeaderComponent } from './site-header/site-header.component';
import { AllCompaniesComponent } from './all-companies/all-companies.component';
import { CreateCompanyComponent } from './create-company/create-company.component';
import { UpdateCompanyComponent } from './update-company/update-company.component';
import { CompanyByIsinComponent } from './company-by-isin/company-by-isin.component';


@NgModule({
  declarations: [
    AppComponent,
    SiteHeaderComponent,
    AllCompaniesComponent,
    CreateCompanyComponent,
    UpdateCompanyComponent,
    CompanyByIsinComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [
    CompanyService,
    provideHttpClient(),
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
