using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Prescription
    {
        // If the clinic issues prescriptions for medications or treatments, this class would store those details.
        public int Id { get; set; }
        public int PatientId { get; set; } // Foreign key to Patient
        public Patient Patient { get; set; } // Navigation property to Patient
        public DateTime IssueDate { get; set; } // Date when the prescription was issued
        public string MedicationName { get; set; } // Name of the medication prescribed
        public string Dosage { get; set; } // Dosage instructions
        public string Duration { get; set; } // Duration for which the medication should be taken
        public string Notes { get; set; } // Any additional instructions related to the prescription
        public DateTime? CreatedDate { get; set; }  // Bu özellik artık nullable değil ve tip belirtilmiş.
        public DateTime? UpdatedDate { get; set; } // Nullable DateTime
    }
}
