using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Model
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }

        [Required]
        [Display(Name = "Customer", Order = 1, Description = "Select the customer associated with this invoice")]
        public int CustomerID { get; set; }

        [Required]
        [Display(Name = "Invoice Date", Order = 2, Description = "Date the invoice was generated")]
        public DateTime InvoiceDate { get; set; }

        [Required]
        [Display(Name = "Total Amount", Order = 3, Description = "Total amount for the invoice")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }

        [Required]
        [Display(Name = "Status", Order = 4, Description = "Status of the invoice (Paid/Unpaid)")]
        public string Status { get; set; } = "Unpaid";
    }
}
