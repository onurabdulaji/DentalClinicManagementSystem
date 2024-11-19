using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Treatment
    {
        // This class will store details about specific dental treatments a patient receives.
        public int Id { get; set; }
        public int PatientId { get; set; } // Foreign key to Patient
        public Patient Patient { get; set; } // Navigation property to Patient
        public string TreatmentName { get; set; } // Name of the treatment (e.g., root canal, cleaning)
        public DateTime TreatmentDate { get; set; } // Date when the treatment was performed
        public decimal Cost { get; set; } // Cost of the treatment
        public string Description { get; set; } // A detailed description of the procedure
        public bool IsCompleted { get; set; } // Whether the treatment is completed or ongoing

        public DateTime? CreatedDate { get; set; }  // Bu özellik artık nullable değil ve tip belirtilmiş.
        public DateTime? UpdatedDate { get; set; } // Nullable DateTime
    }
}
