using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Model
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }

        [Required]
        [Display(Name = "Invoice", Order = 1, Description = "The invoice being paid")]
        public int InvoiceID { get; set; }

        [Required]
        [Display(Name = "Payment Date", Order = 2, Description = "Date the payment was made")]
        public DateTime PaymentDate { get; set; }

        [Required]
        [Display(Name = "Amount Paid", Order = 3, Description = "Amount paid towards the invoice")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal AmountPaid { get; set; }

        [Required]
        [Display(Name = "Payment Method", Order = 4, Description = "Method of payment (Cash, Credit, etc.)")]
        public string PaymentMethod { get; set; } = null!;

        [MaxLength(500)]
        [Display(Name = "Notes", Order = 5, Description = "Any additional notes regarding the payment")]
        public string? Notes { get; set; }
    }
}
