using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Model
{
    public class Promotion
    {
        [Key]
        public int PromoID { get; set; }

        [Required]
        [Display(Name = "Name", Order = 1, Description = "Name of the promotion")]
        [MaxLength(255)]
        public string Name { get; set; } = null!;

        [Required]
        [Display(Name = "Start Date", Order = 2, Description = "Start date of the promotion")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date", Order = 3, Description = "End date of the promotion")]
        public DateTime EndDate { get; set; }

        [Required]
        [Display(Name = "Discount Type", Order = 4, Description = "Type of discount offered")]
        [MaxLength(50)]
        public string DiscountType { get; set; } = null!;

        [Required]
        [Display(Name = "Discount Value", Order = 5, Description = "Value of the discount")]
        public decimal DiscountValue { get; set; }

        [Required]
        [Display(Name = "Status", Order = 6, Description = "Status of the promotion")]
        [MaxLength(50)]
        public string Status { get; set; } = null!;
    }
}