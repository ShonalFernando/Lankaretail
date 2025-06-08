using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaRetail.Model
{
    public class Coupon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CouponId { get; set; }

        [Required]
        public string Code { get; set; }

        public decimal DiscountAmount { get; set; }

        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}
