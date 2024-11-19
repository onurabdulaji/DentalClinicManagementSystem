using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Invoice
    {
        // To keep track of billing and payments for patients, the Invoice class can be used.
        public int Id { get; set; }
        public int PatientId { get; set; } // Foreign key to Patient
        public virtual Patient Patient { get; set; } // Navigation property to Patient
        public DateTime InvoiceDate { get; set; } // Date when the invoice was generated
        public decimal TotalAmount { get; set; } // Total amount for the treatments
        public decimal AmountPaid { get; set; } // Amount already paid
        public decimal Balance { get; set; } // Remaining balance
        public string Status { get; set; } // Status of the invoice (e.g., Paid, Unpaid, Pending)
        public string PaymentMethod { get; set; } // Method used for payment (e.g., Cash, Credit Card, Insurance)

        // Navigation property for the Payments collection
        public virtual ICollection<Payment> Payments { get; set; } // One-to-many relationship with Payment
        public DateTime? CreatedDate { get; set; }  // Bu özellik artık nullable değil ve tip belirtilmiş.
        public DateTime? UpdatedDate { get; set; } // Nullable DateTime

    }
}
