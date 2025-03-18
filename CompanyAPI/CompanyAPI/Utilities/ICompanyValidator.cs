namespace CompanyAPI.Utilities
{
    public interface ICompanyValidator
    {
        bool IsIsinDuplicate(string isin);
        bool IsIsinInvalid(string isin);
    }
}
