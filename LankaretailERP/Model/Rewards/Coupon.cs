using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Model
{
    public class Coupon
    {
        [Key]
        public int CouponID { get; set; }

        [Required]
        [ForeignKey("Promotion")]
        [Display(Name = "Promotion ID", Order = 1, Description = "Related promotion ID")]
        public int PromoID { get; set; }

        [Required]
        [Display(Name = "Code", Order = 2, Description = "Unique coupon code")]
        [MaxLength(100)]
        public string Code { get; set; } = null!;

        [Required]
        [Display(Name = "Discount Value", Order = 3, Description = "Discount value of the coupon")]
        public decimal DiscountValue { get; set; }

        [Required]
        [Display(Name = "Expiry Date", Order = 4, Description = "Expiry date of the coupon")]
        public DateTime ExpiryDate { get; set; }

        [Required]
        [Display(Name = "Status", Order = 5, Description = "Status of the coupon")]
        [MaxLength(50)]
        public string Status { get; set; } = null!;
    }
}
