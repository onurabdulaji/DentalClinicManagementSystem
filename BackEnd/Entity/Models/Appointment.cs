using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Appointment
    {
        // This class will handle patient appointments, including details about the date, time, and the type of treatment.

        public int Id { get; set; }
        public int PatientId { get; set; } // Foreign key to Patient
        public virtual Patient Patient { get; set; } // Navigation property to Patient
        public DateTime AppointmentDate { get; set; } // Date and time of appointment
        public string TreatmentType { get; set; } // Type of treatment (e.g., cleaning, filling, extraction)
        public string Status { get; set; } // Status of the appointment (e.g., Scheduled, Completed, Canceled)
        public string Notes { get; set; } // Any additional notes or instructions

        // CreatedDate ve UpdatedDate ekleyin
        public DateTime? CreatedDate { get; set; }  // DateTime türünde olmalı
        public DateTime? UpdatedDate { get; set; } // Nullable DateTime
    }
}
