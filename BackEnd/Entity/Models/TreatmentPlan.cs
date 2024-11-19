using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class TreatmentPlan
    {
        // If the clinic uses treatment plans for patients, this class will define the plan for treatment over time.
        public int Id { get; set; }
        public int PatientId { get; set; } // Foreign key to Patient
        public Patient Patient { get; set; } // Navigation property to Patient
        public string PlanName { get; set; } // Name or title of the plan (e.g., "Orthodontic Treatment")
        public DateTime StartDate { get; set; } // Date the treatment plan starts
        public DateTime EndDate { get; set; } // Date the treatment plan ends
        public string Description { get; set; } // A detailed description of the treatment plan
        public decimal EstimatedCost { get; set; } // Estimated cost of the treatment plan
        public bool IsCompleted { get; set; } // Whether the plan is completed

        public DateTime? CreatedDate { get; set; }  // Bu özellik artık nullable değil ve tip belirtilmiş.
        public DateTime? UpdatedDate { get; set; } // Nullable DateTime
    }
}
