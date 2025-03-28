using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Model
{
    public class PurchaseOrderItem
    {
        [Key]
        public int PurchaseOrderItemID { get; set; }

        [Required]
        [Display(Name = "Purchase Order", Order = 1, Description = "The purchase order this item belongs to")]
        public int PurchaseOrderID { get; set; }

        [Required]
        [Display(Name = "Item Name", Order = 2, Description = "The name of the item being purchased")]
        public string ItemName { get; set; } = null!;

        [Required]
        [Display(Name = "Quantity", Order = 3, Description = "Number of units ordered")]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Unit Price", Order = 4, Description = "Price per unit of the item")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }

        [Required]
        [Display(Name = "Total Price", Order = 5, Description = "Total cost of this item in the order")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }
    }
}
