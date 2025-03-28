using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Model
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Role Name", Order = 1, Description = "Enter the role name")]
        public string RoleName { get; set; } = null!;

        [MaxLength(500)]
        [Display(Name = "Description", Order = 2, Description = "Provide a brief description of the role")]
        public string? Description { get; set; }

        [Required]
        [Display(Name = "Permissions", Order = 3, Description = "Specify the permissions for this role")]
        public string Permissions { get; set; } = null!;

        [Required]
        [Display(Name = "Status", Order = 4, Description = "Indicate whether the role is active or inactive")]
        public bool Status { get; set; }
    }
}
