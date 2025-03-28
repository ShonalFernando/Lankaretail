using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Model
{
    public class StockMovement
    {
        [Key]
        public int MovementID { get; set; }

        [Required]
        public int BatchID { get; set; }

        [Required]
        public int FromWarehouseID { get; set; }

        [Required]
        public int ToWarehouseID { get; set; }

        [Required]
        [Display(Name = "Quantity", Order = 1, Description = "Quantity moved between warehouses")]
        public int Quantity { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Movement Type", Order = 2, Description = "Type of stock movement (e.g., transfer, return)")]
        public string MovementType { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Date", Order = 3, Description = "Date of movement")]
        public DateTime Date { get; set; }

        [Required]
        public int HandledByID { get; set; }
    }

}
