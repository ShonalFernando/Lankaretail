using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaRetail.Model
{
    public class InventoryReport
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReportId { get; set; }

        public DateTime ReportDate { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public int WarehouseId { get; set; }
        [ForeignKey("WarehouseId")]
        public Warehouse Warehouse { get; set; }

        public int QuantityInStock { get; set; }
        public int QuantitySold { get; set; }
        public decimal TotalValue { get; set; }  // QuantityInStock * AverageCost

        public string Status { get; set; } // e.g., "Normal", "Low Stock", "Out of Stock"
    }
}
