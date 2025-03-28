using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Model
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Full Name", Order = 1, Description = "Enter the full name of the employee")]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Date of Birth", Order = 2, Description = "Employee's date of birth")]
        public DateTime DateOfBirth { get; set; }
    }
}
