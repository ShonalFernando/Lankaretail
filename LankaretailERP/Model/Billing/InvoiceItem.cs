using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Model
{
    public class InvoiceItem
    {
        [Key]
        public int InvoiceItemID { get; set; }

        [Required]
        [Display(Name = "Invoice", Order = 1, Description = "The invoice associated with this item")]
        public int InvoiceID { get; set; }

        [Required]
        [Display(Name = "Product", Order = 2, Description = "The product or service being billed")]
        public string ProductName { get; set; } = null!;

        [Required]
        [Display(Name = "Quantity", Order = 3, Description = "Number of units sold")]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Unit Price", Order = 4, Description = "Price per unit")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }

        [Required]
        [Display(Name = "Total Price", Order = 5, Description = "Total price for this item")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }
    }
}
