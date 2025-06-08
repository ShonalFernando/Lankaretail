using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LankaRetail.Model.Billing;

namespace LankaRetail.Model
{
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceId { get; set; }

        public int? LoyaltyCustomerId { get; set; }

        [ForeignKey("LoyaltyCustomerId")]
        public LoyaltyCustomer LoyaltyCustomer { get; set; }

        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        public DateTime Date { get; set; }

        public decimal TotalAmount { get; set; }
    }
}
