import { Component } from '@angular/core';
import { Company } from '../models/Company';
import { CompanyService } from '../company.service';

@Component({
  selector: 'app-company-by-isin',
  standalone: false,
  templateUrl: './company-by-isin.component.html',
  styleUrl: './company-by-isin.component.css'
})
export class CompanyByIsinComponent {
  public isin: string = '';
  public companyByIsin?: Company;

  constructor(private companyService: CompanyService) {}

  public getCompanyByIsin(isin: string) {
    this.companyService.getCompanyByIsin(isin).subscribe(company => {
      if (company !== null) {
        this.companyByIsin = company;
      } else {
        alert(`There is no company with Isin: ${isin}`);
      }
    })
  }
}
