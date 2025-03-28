using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Model
{
    public class PurchaseOrder
    {
        [Key]
        public int PurchaseOrderID { get; set; }

        [Required]
        [Display(Name = "Supplier", Order = 1, Description = "Select the supplier for this order")]
        public int SupplierID { get; set; }

        [Required]
        [Display(Name = "Order Date", Order = 2, Description = "Date the purchase order was created")]
        public DateTime OrderDate { get; set; }

        [Required]
        [Display(Name = "Total Amount", Order = 3, Description = "Total amount of the purchase order")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }

        [Required]
        [Display(Name = "Status", Order = 4, Description = "Current status of the purchase order (Pending, Approved, Received)")]
        public string Status { get; set; } = "Pending";
    }
}
