using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaRetail.Model
{
    public class GoodsReceived
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GoodsReceivedId { get; set; }

        public int PurchaseOrderId { get; set; }
        [ForeignKey("PurchaseOrderId")]
        public PurchaseOrder PurchaseOrder { get; set; }

        public int ReceivedById { get; set; }
        [ForeignKey("ReceivedById")]
        public Employee ReceivedBy { get; set; }

        public DateTime ReceivedDate { get; set; }
    }
}
