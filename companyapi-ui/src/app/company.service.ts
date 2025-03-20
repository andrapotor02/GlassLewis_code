import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Company } from './models/Company';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CompanyService {

  constructor(private readonly httpClient: HttpClient) { }

  private readonly companyServiceUrl = "https://localhost:7202/api/Company";

  public getAllCompanies(): Observable<Company[]> {
    const url = `${this.companyServiceUrl}/companies`;
    return this.httpClient.get<Company[]>(url);
  }

  public createCompany(company: Company) {
    const url = `${this.companyServiceUrl}/createCompany`;
    return this.httpClient.post<Company>(url, company);
  }

  public getCompanyById(companyId: string): Observable<Company> {
    const url = `${this.companyServiceUrl}/companyid/${companyId}`;
    return this.httpClient.get<Company>(url);
  }

  public getCompanyByIsin(isin: string): Observable<Company> {
    const url = `${this.companyServiceUrl}/isin/${isin}`;
    return this.httpClient.get<Company>(url);
  }

  public updateCompany(company: Company) {
    const url = `${this.companyServiceUrl}/updateCompany`;
    return this.httpClient.post<Company>(url, company);
  }
}
