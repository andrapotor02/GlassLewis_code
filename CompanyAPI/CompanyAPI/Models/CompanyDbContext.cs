using Microsoft.EntityFrameworkCore;

namespace CompanyAPI.Models
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options)
        {
            
        }

        public DbSet<Company> Companies { get; set; }
    }
}
