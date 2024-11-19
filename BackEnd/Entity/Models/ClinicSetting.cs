using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class ClinicSetting
    {
        // This class will handle various clinic settings, such as office hours, clinic address, etc.
        public int Id { get; set; }
        public string ClinicName { get; set; } // Name of the clinic
        public string Address { get; set; } // Clinic's address
        public string ContactNumber { get; set; } // Clinic's contact number
        public string Email { get; set; } // Clinic's email address
        public string OfficeHours { get; set; } // Clinic's office hours (e.g., "Mon-Fri: 9AM - 6PM")

        public DateTime? CreatedDate { get; set; }  // Bu özellik artık nullable değil ve tip belirtilmiş.
        public DateTime? UpdatedDate { get; set; } // Nullable DateTime
    }
}
