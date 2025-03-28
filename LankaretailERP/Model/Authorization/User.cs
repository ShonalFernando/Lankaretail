using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Model
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Full Name", Order = 1, Description = "Enter the full name of the user")]
        public string FullName { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        [Display(Name = "Username", Order = 2, Description = "Enter a unique username")]
        public string Username { get; set; } = null!;

        [Required]
        [MaxLength(256)]
        [Display(Name = "Password Hash", Order = 3, Description = "Hashed password for authentication")]
        public string PasswordHash { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        [Display(Name = "Email Address", Order = 4, Description = "User's email address")]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [Display(Name = "Role", Order = 5, Description = "User's role in the system")]
        public string Role { get; set; } = "User";

        [Required]
        [Display(Name = "Account Created", Order = 6, Description = "Date and time the account was created")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Display(Name = "Last Login", Order = 7, Description = "Last login date and time")]
        public DateTime? LastLogin { get; set; }

        [Display(Name = "Is Active", Order = 8, Description = "Indicates if the account is active")]
        public bool IsActive { get; set; } = true;
    }
}
