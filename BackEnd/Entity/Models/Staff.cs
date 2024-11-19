using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Staff
    {
        //This class will represent staff members such as dentists and hygienists working at the clinic.
        public int Id { get; set; }
        public string FirstName { get; set; } // First name of the staff member
        public string LastName { get; set; } // Last name of the staff member
        public string Role { get; set; } // Role (e.g., Dentist, Hygienist, Receptionist)
        public string Email { get; set; } // Email address
        public string PhoneNumber { get; set; } // Phone number
        public decimal Salary { get; set; } // Staff member's salary
        public DateTime HireDate { get; set; } // Date when the staff member was hired
        public string Qualifications { get; set; } // Any relevant qualifications (for example, for dentists)

        public DateTime? CreatedDate { get; set; }  // Bu özellik artık nullable değil ve tip belirtilmiş.
        public DateTime? UpdatedDate { get; set; } // Nullable DateTime
    }
}
