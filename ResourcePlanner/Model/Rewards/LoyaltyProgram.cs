using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaRetail.Model
{
    public class LoyaltyProgram
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LoyaltyProgramId { get; set; }

        public string Name { get; set; }
        public string Rules { get; set; }

        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}
