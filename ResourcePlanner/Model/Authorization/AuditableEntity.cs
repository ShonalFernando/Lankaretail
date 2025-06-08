using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaRetail.Model
{
    public abstract class AuditableEntity
    {
        [Required]
        [MaxLength(100)]
        public string AddedBy { get; set; }

        [Required]
        public DateTime AddedDate { get; set; } = DateTime.UtcNow;
    }
}
