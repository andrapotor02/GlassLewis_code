namespace CompanyAPI.Models
{
    public static class DbInitializer
    {
        public static void Seed(CompanyDbContext context)
        {
            if (!context.Companies.Any())
            {
                context.Companies.Add(new Company
                {
                    CompanyName = "Apple Inc.",
                    Exchange = "NASDAQ",
                    StockTicker = "AAPL",
                    Isin = "US0378331005",
                    Website = "http://www.apple.com"
                });

                context.SaveChanges();
            }
        }
    }
}
