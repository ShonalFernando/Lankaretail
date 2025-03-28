using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Model
{
    public class InventoryReport
    {
        [Key]
        public int InventoryReportID { get; set; }

        [Required]
        [Display(Name = "Report Date", Order = 1, Description = "Date the inventory report was generated")]
        public DateTime ReportDate { get; set; }

        [Required]
        [Display(Name = "Total Items", Order = 2, Description = "Total number of unique items in inventory")]
        public int TotalItems { get; set; }

        [Required]
        [Display(Name = "Low Stock Items", Order = 3, Description = "Number of items that are running low")]
        public int LowStockItems { get; set; }

        [Required]
        [Display(Name = "Out of Stock Items", Order = 4, Description = "Number of items that are out of stock")]
        public int OutOfStockItems { get; set; }

        [Required]
        [Display(Name = "Total Inventory Value", Order = 5, Description = "Total value of all inventory items")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalInventoryValue { get; set; }

        [MaxLength(500)]
        [Display(Name = "Remarks", Order = 6, Description = "Additional notes on inventory status")]
        public string? Remarks { get; set; }
    }
}
