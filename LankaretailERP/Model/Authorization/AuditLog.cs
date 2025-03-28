using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Model
{
    public class AuditLog
    {
        [Key]
        public int AuditLogID { get; set; }

        [Required]
        [Display(Name = "User ID", Order = 1, Description = "User who performed the action")]
        public int UserID { get; set; }

        [Required]
        [Display(Name = "Action", Order = 2, Description = "Description of the action performed")]
        [MaxLength(255)]
        public string Action { get; set; } = null!;

        [Required]
        [Display(Name = "Timestamp", Order = 3, Description = "Date and time of the action")]
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        [MaxLength(500)]
        [Display(Name = "Details", Order = 4, Description = "Additional details about the action")]
        public string? Details { get; set; }

        [Required]
        [MaxLength(45)]
        [Display(Name = "IP Address", Order = 5, Description = "IP address of the user performing the action")]
        public string IPAddress { get; set; } = null!;
    }
}
