using CompanyAPI.Utilities;
using Microsoft.EntityFrameworkCore;

namespace CompanyAPI.Models.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly CompanyDbContext _companyDbContext;
        private readonly ICompanyValidator _companyValidator;

        public CompanyRepository(
            CompanyDbContext companyDbContext,
            ICompanyValidator companyValidator)
        {
            _companyDbContext = companyDbContext;
            _companyValidator = companyValidator;
        }

        public async Task<int> AddCompanyAsync(Company company)
        {
            if (_companyValidator.IsIsinDuplicate(company.Isin))
            {
                throw new Exception($"There is already a company that contains the same isin: {company.Isin}.");
            }

            if (_companyValidator.IsIsinInvalid(company.Isin))
            {
                throw new Exception("The first two characters of the Isin must be letters/non numeric.");
            }

            _companyDbContext.Companies.Add(new Company
            {
                CompanyName = company.CompanyName,
                Exchange = company.Exchange,
                StockTicker = company.StockTicker,
                Isin = company.Isin,
                Website = company.Website
            });

            return await _companyDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Company>> GetAllCompaniesAsync()
        {
            return await _companyDbContext.Companies.OrderBy(c => c.CompanyName).AsNoTracking().ToListAsync();
        }

        public async Task<Company?> GetCompanyByIdAsync(int companyId)
        {
            return await _companyDbContext.Companies.FirstOrDefaultAsync(c => c.CompanyId == companyId);
        }

        public async Task<Company?> GetCompanyByIsinAsync(string isin)
        {
            return await _companyDbContext.Companies.FirstOrDefaultAsync(c => c.Isin == isin);
        }

        public async Task<int> UpdateCompanyAsync(Company company)
        {
            var companyToUpdate = await _companyDbContext.Companies.FirstOrDefaultAsync(c => c.CompanyId == company.CompanyId);

            if (companyToUpdate.Isin != company.Isin && _companyValidator.IsIsinDuplicate(company.Isin))
            {
                throw new Exception($"There is already a company that contains the same isin: {company.Isin}.");
            }

            if (companyToUpdate.Isin != company.Isin && _companyValidator.IsIsinInvalid(company.Isin))
            {
                throw new Exception("The first two characters of the Isin must be letters/non numeric.");
            }

            if (companyToUpdate != null)
            {
                companyToUpdate.CompanyName = company.CompanyName;
                companyToUpdate.Exchange = company.Exchange;
                companyToUpdate.StockTicker = company.StockTicker;
                companyToUpdate.Isin = company.Isin;
                companyToUpdate.Website = company.Website;

                _companyDbContext.Companies.Update(companyToUpdate);
                return await _companyDbContext.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentException($"The company: {company.CompanyName} to update can't be found.");
            }
        }
    }
}
