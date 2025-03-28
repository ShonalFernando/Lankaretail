using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Model
{
    public class EmployeePerformance
    {
        [Key]
        public int PerformanceID { get; set; }

        [Required]
        [Display(Name = "Employee ID", Order = 1, Description = "The employee being evaluated")]
        public int EmployeeID { get; set; }

        [Required]
        [Display(Name = "Evaluation Date", Order = 2, Description = "Date of the performance evaluation")]
        public DateTime EvaluationDate { get; set; }

        [Required]
        [Display(Name = "Tasks Completed", Order = 3, Description = "Total number of tasks completed successfully")]
        public int TasksCompleted { get; set; }

        [Required]
        [Display(Name = "Hours Worked", Order = 4, Description = "Total working hours during the evaluation period")]
        public int HoursWorked { get; set; }

        [Required]
        [Display(Name = "Performance Score", Order = 5, Description = "Overall performance rating (out of 100)")]
        public int PerformanceScore { get; set; }

        [MaxLength(500)]
        [Display(Name = "Remarks", Order = 6, Description = "Additional comments on performance")]
        public string? Remarks { get; set; }
    }
}
