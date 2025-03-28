using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Model
{
    public class Batch
    {
        [Key]
        public int BatchID { get; set; }

        [Required]
        public int ProductID { get; set; }

        [Required]
        public int WarehouseID { get; set; }

        [Required]
        [Display(Name = "Cost Price", Order = 1, Description = "Cost price per unit")]
        public decimal CostPrice { get; set; }

        [Required]
        [Display(Name = "Selling Price", Order = 2, Description = "Selling price per unit")]
        public decimal SellingPrice { get; set; }

        [Display(Name = "Discount", Order = 3, Description = "Discount applied to this batch")]
        public decimal Discount { get; set; }

        [Display(Name = "Expiry Date", Order = 4, Description = "Expiration date of the batch")]
        public DateTime ExpiryDate { get; set; }

        [Required]
        [Display(Name = "Quantity", Order = 5, Description = "Total quantity available in stock")]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Status", Order = 6, Description = "Specify if the batch is active or inactive")]
        public bool Status { get; set; }
    }
}
