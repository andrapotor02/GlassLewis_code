import { Component } from '@angular/core';
import { CompanyService } from '../company.service';
import { Company } from '../models/Company';

@Component({
  selector: 'app-all-companies',
  standalone: false,
  templateUrl: './all-companies.component.html',
  styleUrl: './all-companies.component.css'
})
export class AllCompaniesComponent {
  public companies: Company[] = [];

  constructor(private companyService: CompanyService) { }

  ngOnInit() {
    this.companyService.getAllCompanies().subscribe(companies => 
      this.companies = companies
    )
  }
}
