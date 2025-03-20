import { Component } from '@angular/core';
import { CompanyService } from '../company.service';
import { ToastrService } from 'ngx-toastr';

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

  constructor(private companyService: CompanyService, private toastrService: ToastrService) {}

  public createCompany(companyForm: any) {
    this.companyService.createCompany(companyForm).subscribe(() => {
      this.toastrService.success("Successfully created company.");
      setTimeout(() => window.location.reload(), 3000);
    },
  error => alert(error.error.text));
  }
}
