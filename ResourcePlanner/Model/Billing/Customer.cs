using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaRetail.Model.Billing
{
    public class LoyaltyCustomer : AuditableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LoyaltyCustomerId { get; set; }

        [Required]
        public string FullName { get; set; }

        public string Contact { get; set; }

        public int Points { get; set; }
    }
}
