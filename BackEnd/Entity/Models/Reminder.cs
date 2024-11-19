using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Reminder
    {
        // This class will track reminders or tasks associated with a patient's care, such as follow-up appointments or routine check-ups.
        public int Id { get; set; }
        public int PatientId { get; set; } // Foreign key to Patient
        public Patient Patient { get; set; } // Navigation property to Patient
        public DateTime ReminderDate { get; set; } // Date when the reminder is set for
        public string Message { get; set; } // Description of the reminder (e.g., "Follow-up checkup")
        public bool IsCompleted { get; set; } // Whether the reminder has been acted upon

        public DateTime? CreatedDate { get; set; }  // Bu özellik artık nullable değil ve tip belirtilmiş.
        public DateTime? UpdatedDate { get; set; } // Nullable DateTime
    }
}
