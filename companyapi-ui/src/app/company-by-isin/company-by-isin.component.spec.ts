import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CompanyByIsinComponent } from './company-by-isin.component';

describe('CompanyByIsinComponent', () => {
  let component: CompanyByIsinComponent;
  let fixture: ComponentFixture<CompanyByIsinComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CompanyByIsinComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CompanyByIsinComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
