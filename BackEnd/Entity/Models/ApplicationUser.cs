using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string FullName { get; set; } // Full name of the user (e.g., dentist or admin)
        public string Role { get; set; } // Role of the user (e.g., "Admin", "Dentist", "Hygienist")
        public string ProfilePicture { get; set; } // Path to the user's profile picture
        public DateTime? DateOfBirth { get; set; } // User's birthdate
        public bool IsActive { get; set; } // Whether the user is active in the system
        public DateTime? CreatedDate { get; set; }  // Bu özellik artık nullable değil ve tip belirtilmiş.
        public DateTime? UpdatedDate { get; set; } // Nullable DateTime
    }
}
