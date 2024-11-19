using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Patient
    {
        // Unique identifier for the patient
        public int Id { get; set; }

        // Personal details
        public string FirstName { get; set; }  // Patient's first name
        public string LastName { get; set; }   // Patient's last name
        public DateTime DateOfBirth { get; set; } // Date of birth
        public string Gender { get; set; }  // Gender (could be "Male", "Female", "Other")

        // Contact details
        public string PhoneNumber { get; set; } // Primary contact number
        public string Email { get; set; }  // Email address
        public string Address { get; set; } // Residential address

        // Emergency contact information
        public string EmergencyContactName { get; set; } // Name of the emergency contact
        public string EmergencyContactPhone { get; set; } // Emergency contact phone number

        // Medical history and notes
        public string MedicalHistory { get; set; } // Details about previous medical or dental conditions
        public string Allergies { get; set; }  // Any known allergies
        public string Medications { get; set; } // Ongoing medications, if any
        public string InsuranceDetails { get; set; }  // Insurance information (if applicable)

        // Dental-specific details
        public DateTime LastVisitDate { get; set; } // Date of the last visit
        public string Notes { get; set; } // Additional notes, e.g., treatment plans or special instructions

        // Status of the patient's account or records
        public bool IsActive { get; set; } // Whether the patient is an active client of the clinic

        // Navigation property for appointments (one Patient can have many Appointments)
        public ICollection<Appointment> Appointments { get; set; } // A collection of related Appointments
        public ICollection<Invoice> Invoices { get; set; } // One-to-many relationship (Patient -> Invoices)
        public ICollection<Prescription> Prescriptions { get; set; } // A patient can have multiple prescriptions
        public ICollection<Reminder> Reminders { get; set; }

        public DateTime? CreatedDate { get; set; }  // Bu özellik artık nullable değil ve tip belirtilmiş.
        public DateTime? UpdatedDate { get; set; } // Nullable DateTime

    }
}