using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Payment
    {
        // If you're tracking individual payments (rather than just invoices), the Payment class will be useful.
        public int Id { get; set; }
        public int InvoiceId { get; set; } // Foreign key to Invoice
        public Invoice Invoice { get; set; } // Navigation property to Invoice
        public DateTime PaymentDate { get; set; } // Date when the payment was made
        public decimal AmountPaid { get; set; } // Amount paid in this transaction
        public string PaymentMethod { get; set; } // Payment method (Cash, Credit Card, Insurance)
        public string TransactionId { get; set; } // Transaction identifier (if applicable)

        public DateTime? CreatedDate { get; set; }  // Bu özellik artık nullable değil ve tip belirtilmiş.
        public DateTime? UpdatedDate { get; set; } // Nullable DateTime
    }
}
