import { Component } from '@angular/core';
import { CompanyService } from '../company.service';
import { Company } from '../models/Company';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-update-company',
  standalone: false,
  templateUrl: './update-company.component.html',
  styleUrl: './update-company.component.css'
})
export class UpdateCompanyComponent {
  public companyId: string = '';
  companyDetails?: Company;

  constructor(private companyService: CompanyService, private toastr: ToastrService) {}

  public getCompanyById(companyId: string) {
    this.companyService.getCompanyById(companyId).subscribe(company => {
      if (company !== null) {
        this.companyDetails = company;
      } else {
        this.toastr.error(`There is no company with Id: ${companyId}`);
      }
    })
  }

  public updateCompany(company: Company) {
    this.companyService.updateCompany(company).subscribe(() => {
      this.toastr.success(`Successfully updated company ${company.companyName}.`);
      setTimeout(() => window.location.reload(), 3000);
    },
    error => alert(error.error.text));
  }

}
