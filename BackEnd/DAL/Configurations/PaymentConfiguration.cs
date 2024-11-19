using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class PaymentConfiguration : BaseConfiguration<Payment>
    {
        public override void Configure(EntityTypeBuilder<Payment> builder)
        {
            base.Configure(builder);

            // Set the primary key for Payment
            builder.HasKey(x => x.Id); // 'Id' is the primary key

            // Configure InvoiceId as a foreign key
            builder.HasOne(x => x.Invoice) // Each Payment is associated with one Invoice
                   .WithMany(x => x.Payments) // An Invoice can have many Payments
                   .HasForeignKey(x => x.InvoiceId) // Foreign key to Invoice
                   .OnDelete(DeleteBehavior.Cascade); // Optional: Cascade delete when Invoice is deleted

            // Configure PaymentDate (required)
            builder.Property(x => x.PaymentDate)
                   .IsRequired(); // PaymentDate is required

            // Configure AmountPaid (required) and define the decimal precision
            builder.Property(x => x.AmountPaid)
                   .IsRequired() // AmountPaid is required
                   .HasColumnType("decimal(18,2)"); // Amount paid should be of decimal type with precision (18,2)

            // Configure PaymentMethod (optional)
            builder.Property(x => x.PaymentMethod)
                   .HasMaxLength(50); // Max length for PaymentMethod (e.g., Cash, Credit Card, Insurance)

            // Configure TransactionId (optional) with max length
            builder.Property(x => x.TransactionId)
                   .HasMaxLength(100); // Max length for TransactionId (if applicable)

        }
    }
}
