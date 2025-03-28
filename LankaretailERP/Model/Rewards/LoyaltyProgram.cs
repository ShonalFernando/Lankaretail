using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Model
{
    public class LoyaltyProgram
    {
        [Key]
        public int LoyaltyID { get; set; }

        [Required]
        [Display(Name = "Customer ID", Order = 1, Description = "ID of the customer")]
        public int CustomerID { get; set; }

        [Required]
        [Display(Name = "Points Earned", Order = 2, Description = "Total points earned by the customer")]
        public int PointsEarned { get; set; }

        [Required]
        [Display(Name = "Points Redeemed", Order = 3, Description = "Total points redeemed by the customer")]
        public int PointsRedeemed { get; set; }

        [Required]
        [Display(Name = "Last Updated Date", Order = 4, Description = "Last updated date of the loyalty program")]
        public DateTime LastUpdatedDate { get; set; } = DateTime.UtcNow;
    }
}
