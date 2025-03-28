using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Model
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name = "Supplier Name", Order = 1, Description = "Enter the supplier's name")]
        public string SupplierName { get; set; } = null!;

        [MaxLength(100)]
        [Display(Name = "Contact Person", Order = 2, Description = "Enter the contact person's name")]
        public string? ContactPerson { get; set; }

        [MaxLength(50)]
        [Display(Name = "Phone Number", Order = 3, Description = "Enter the supplier's phone number")]
        public string? PhoneNumber { get; set; }

        [MaxLength(250)]
        [Display(Name = "Email", Order = 4, Description = "Enter the supplier's email address")]
        public string? Email { get; set; }

        [MaxLength(300)]
        [Display(Name = "Address", Order = 5, Description = "Enter the supplier's address")]
        public string? Address { get; set; }
    }
}
