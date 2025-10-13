using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stock
{
    public class CreateStockRequestDTO
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol Cannot Be Over 10 Characters")]
        public string Symbol { get; set; } = string.Empty;

        [Required]
        [MaxLength(10, ErrorMessage = "Company Name Cannot Be Over 10 Characters")]
        public string CompanyName { get; set; } = string.Empty;

        [Required]
        [Range(1, 1000000000)]
        public decimal Purchase { get; set; }

        [Required]
        [Range(0.001, 1000)]
        public decimal LastDiv { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Industry Cannot Be Over 20 Characters")]
        public string Industry { get; set; } = string.Empty;

        [Range(1, 5000000000)]
        public long MarketCap { get; set; }
    }
}