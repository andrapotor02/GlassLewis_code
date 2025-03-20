import { Component } from '@angular/core';
import { CompanyService } from '../company.service';
import { Company } from '../models/Company';

@Component({
  selector: 'app-update-company',
  standalone: false,
  templateUrl: './update-company.component.html',
  styleUrl: './update-company.component.css'
})
export class UpdateCompanyComponent {
  public companyId: string = '';
  companyDetails?: Company;

  constructor(private companyService: CompanyService) {}

  public getCompanyById(companyId: string) {
    this.companyService.getCompanyById(companyId).subscribe(company => {
      if (company !== null) {
        this.companyDetails = company;
      } else {
        alert(`There is no company with Id: ${companyId}`);
      }
    })
  }

  public updateCompany(company: Company) {
    this.companyService.updateCompany(company).subscribe(() => {
      setTimeout(() => window.location.reload())
    },
    error => alert(error.error.text));
  }

}
