using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Model
{
    public class Roster
    {
        [Key]
        public int RosterID { get; set; }

        [Required]
        [Display(Name = "Employee", Order = 1, Description = "Select the employee assigned to this shift")]
        public int EmployeeID { get; set; }

        [Required]
        [Display(Name = "Shift Start", Order = 2, Description = "Specify the shift start time")]
        public DateTime ShiftStart { get; set; }

        [Required]
        [Display(Name = "Shift End", Order = 3, Description = "Specify the shift end time")]
        public DateTime ShiftEnd { get; set; }

        [Required]
        [Display(Name = "Date", Order = 4, Description = "Select the date for this shift")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Assigned By", Order = 5, Description = "Manager or admin who assigned this shift")]
        public int AssignedByID { get; set; }
    }
}
