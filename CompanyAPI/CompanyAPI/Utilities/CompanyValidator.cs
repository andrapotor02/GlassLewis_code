using CompanyAPI.Models;

namespace CompanyAPI.Utilities
{
    public class CompanyValidator : ICompanyValidator
    {
        private readonly CompanyDbContext _companyDbContext;

        public CompanyValidator(CompanyDbContext companyDbContext)
        {
            _companyDbContext = companyDbContext;
        }

        public bool IsIsinDuplicate(string isin)
        {
            var companiesIsin = _companyDbContext
                .Companies
                .Select(x => x.Isin);

            return companiesIsin.Contains(isin);
        }

        public bool IsIsinInvalid(string isin)
        {
            var firstIsinCharacters = isin.Substring(0, 2);

            return int.TryParse(firstIsinCharacters, out _);
        }
    }
}
