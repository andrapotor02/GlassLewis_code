namespace CompanyAPI.Models.Repositories
{
    public interface ICompanyRepository
    {
        Task<int> AddCompanyAsync(Company company);
        Task<IEnumerable<Company>> GetAllCompaniesAsync();
        Task<Company?> GetCompanyByIdAsync(int companyId);
        Task<Company?> GetCompanyByIsinAsync(string isin);
        Task<int> UpdateCompanyAsync(Company company);
    }
}
