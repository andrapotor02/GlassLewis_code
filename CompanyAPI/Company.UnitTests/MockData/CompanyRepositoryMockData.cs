namespace Company.UnitTests.MockData
{
    public static class CompanyRepositoryMockData
    {
        public static IEnumerable<CompanyAPI.Models.Company> Companies = new List<CompanyAPI.Models.Company>()
        {
            new CompanyAPI.Models.Company()
            {
                CompanyId = 100,
                CompanyName = "Test",
                Exchange = "Exchange Test",
                StockTicker = "Stock Ticker Test",
                Isin = "Isin Test",
                Website = "Website Test"
            },
            new CompanyAPI.Models.Company()
            {
                CompanyId = 101,
                CompanyName = "Test1",
                Exchange = "Exchange Test1",
                StockTicker = "Stock Ticker Test1",
                Isin = "Isin Test1",
                Website = "Website Test1"
            },
            new CompanyAPI.Models.Company()
            {
                CompanyId = 102,
                CompanyName = "Tes2t",
                Exchange = "Exchange Test2",
                StockTicker = "Stock Ticker Test2",
                Isin = "Isin Test2",
                Website = "Website Test2"
            }
        };

        public static CompanyAPI.Models.Company Company = new CompanyAPI.Models.Company()
        {
            CompanyId = 100,
            CompanyName = "Test",
            Exchange = "Exchange Test",
            StockTicker = "Stock Ticker Test",
            Isin = "Isin Test",
            Website = "Website Test"
        };
    }
}
