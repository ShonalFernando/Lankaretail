using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Model.Billing
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name = "Full Name", Order = 1, Description = "Enter the full name of the customer")]
        public string FullName { get; set; } = null!;

        [MaxLength(50)]
        [Display(Name = "Contact Number", Order = 2, Description = "Enter the customer's contact number")]
        public string? ContactNumber { get; set; }

        [MaxLength(250)]
        [Display(Name = "Email", Order = 3, Description = "Enter the customer's email address")]
        public string? Email { get; set; }

        [MaxLength(300)]
        [Display(Name = "Address", Order = 4, Description = "Enter the customer's address")]
        public string? Address { get; set; }
    }
}
