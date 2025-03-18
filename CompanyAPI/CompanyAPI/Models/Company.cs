using System.ComponentModel.DataAnnotations;

namespace CompanyAPI.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string Exchange { get; set; }

        [Required]
        public string StockTicker { get; set; }

        [Required]
        public string Isin { get; set; }

        public string? Website { get; set; }
    }
}
