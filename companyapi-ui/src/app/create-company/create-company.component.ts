import { Component } from '@angular/core';
import { CompanyService } from '../company.service';

@Component({
  selector: 'app-create-company',
  standalone: false,
  templateUrl: './create-company.component.html',
  styleUrl: './create-company.component.css'
})
export class CreateCompanyComponent {
  companyDetails = {
      companyName: '',
      exchange: '',
      stockTicker: '',
      isin: '',
      website: ''
    }

  constructor(private companyService: CompanyService) {}

  public createCompany(companyForm: any) {
    this.companyService.createCompany(companyForm).subscribe(() => {
      setTimeout(() => window.location.reload())
    },
  error => alert(error.error.text));
  }
}
