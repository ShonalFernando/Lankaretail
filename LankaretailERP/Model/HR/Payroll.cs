using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Model
{
    public class Payroll
    {
        [Key]
        public int PayrollID { get; set; }

        [Required]
        public int EmployeeID { get; set; }

        [Required]
        [Display(Name = "Basic Salary", Order = 1, Description = "Basic salary of the employee")]
        public decimal BasicSalary { get; set; }
    }
}
