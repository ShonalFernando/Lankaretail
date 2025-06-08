using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaRetail.Model
{
    // Used to Track From and where to the Stock has been moved
    public class StockMovement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StockMovementId { get; set; }

        public int BatchId { get; set; }
        [ForeignKey("BatchId")]
        public Batch Batch { get; set; }

        public int FromWarehouseId { get; set; }
        public int ToWarehouseId { get; set; }

        public DateTime MovementDate { get; set; }
        public int Quantity { get; set; }
    }
}
