using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Model
{
    class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Product Name", Order = 1, Description = "Enter the product name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int CategoryID { get; set; }

        [MaxLength(255)]
        [Display(Name = "Description", Order = 2, Description = "Provide a brief description of the product")]
        public string? Description { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Unit of Measure", Order = 3, Description = "Specify the unit of measurement")]
        public string UnitOfMeasure { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Reorder Level", Order = 4, Description = "Set the minimum stock level before reordering")]
        public int ReorderLevel { get; set; }

        [Required]
        [Display(Name = "Status", Order = 5, Description = "Specify if the product is active or inactive")]
        public bool Status { get; set; }
    }
}
