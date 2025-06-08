using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaRetail.Model
{
    public class SalesReport
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReportId { get; set; }

        public DateTime ReportDate { get; set; }

        public int? EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        public int TotalInvoices { get; set; }
        public int TotalItemsSold { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalDiscounts { get; set; }
        public string PeriodType { get; set; } // e.g., "Daily", "Monthly"
    }
}
