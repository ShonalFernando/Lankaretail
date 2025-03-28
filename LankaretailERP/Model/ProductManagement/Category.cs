using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Model
{
    class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Category Name", Order = 1, Description = "Enter the category name")]
        public string Name { get; set; } = string.Empty;

        [MaxLength(255)]
        [Display(Name = "Description", Order = 2, Description = "Provide a brief description of the category")]
        public string? Description { get; set; }

        [Required]
        [Display(Name = "Status", Order = 3, Description = "Specify if the category is active or inactive")]
        public bool Status { get; set; }
    }
}
