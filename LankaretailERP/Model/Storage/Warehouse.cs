using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Model
{
    public class Warehouse
    {
        [Key]
        public int WarehouseID { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Warehouse Name", Order = 1, Description = "Name of the warehouse")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        [Display(Name = "Location", Order = 2, Description = "Location of the warehouse")]
        public string Location { get; set; } = string.Empty;

        [Required]
        public int ManagerID { get; set; }

        [Required]
        [Display(Name = "Status", Order = 3, Description = "Specify if the warehouse is active or inactive")]
        public bool Status { get; set; }
    }
}
