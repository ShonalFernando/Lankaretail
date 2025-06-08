using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaRetail.Model
{
    public class Warehouse : AuditableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WarehouseId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Location { get; set; }

        public ICollection<Batch> Batches { get; set; } = new List<Batch>();
    }
}