using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Model
{
    public class SalesReport
    {
        [Key]
        public int SalesReportID { get; set; }

        [Required]
        [Display(Name = "Report Date", Order = 1, Description = "Date of the sales report")]
        public DateTime ReportDate { get; set; }

        [Required]
        [Display(Name = "Total Sales", Order = 2, Description = "Total revenue generated")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalSales { get; set; }

        [Required]
        [Display(Name = "Total Transactions", Order = 3, Description = "Total number of transactions")]
        public int TotalTransactions { get; set; }

        [Required]
        [Display(Name = "Best Selling Product", Order = 4, Description = "The most sold product during the period")]
        public string BestSellingProduct { get; set; } = null!;

        [MaxLength(500)]
        [Display(Name = "Remarks", Order = 5, Description = "Additional comments or notes")]
        public string? Remarks { get; set; }
    }
}
