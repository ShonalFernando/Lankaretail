using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Model
{
    public class GoodsReceived
    {
        [Key]
        public int GoodsReceivedID { get; set; }

        [Required]
        [Display(Name = "Purchase Order", Order = 1, Description = "The purchase order related to these goods")]
        public int PurchaseOrderID { get; set; }

        [Required]
        [Display(Name = "Received Date", Order = 2, Description = "Date the goods were received")]
        public DateTime ReceivedDate { get; set; }

        [Required]
        [Display(Name = "Received By", Order = 3, Description = "Employee who received the goods")]
        public int ReceivedByID { get; set; }

        [Required]
        [Display(Name = "Total Items", Order = 4, Description = "Total number of items received")]
        public int TotalItems { get; set; }

        [MaxLength(500)]
        [Display(Name = "Remarks", Order = 5, Description = "Additional notes about the received goods")]
        public string? Remarks { get; set; }
    }
}
