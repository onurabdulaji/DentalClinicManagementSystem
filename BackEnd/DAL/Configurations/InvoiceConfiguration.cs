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
    public class InvoiceConfiguration : BaseConfiguration<Invoice>
    {
        public override void Configure(EntityTypeBuilder<Invoice> builder)
        {
            base.Configure(builder);

            // Set the primary key for Invoice
            builder.HasKey(x => x.Id); // The primary key is 'Id'

            // Configure the PatientId as a foreign key
            builder.HasOne(x => x.Patient) // Assuming Invoice has a navigation property 'Patient'
                   .WithMany(p => p.Invoices) // Assuming Patient has a collection of Invoices
                   .HasForeignKey(x => x.PatientId); // Foreign key is 'PatientId'

            // Configure other properties
            builder.Property(x => x.InvoiceDate)
                   .IsRequired(); // InvoiceDate is required

            builder.Property(x => x.TotalAmount)
                   .IsRequired() // TotalAmount is required
                   .HasColumnType("decimal(18,2)"); // Ensure precision for money values

            builder.Property(x => x.AmountPaid)
                   .IsRequired() // AmountPaid is required
                   .HasColumnType("decimal(18,2)"); // Ensure precision for money values

            builder.Property(x => x.Balance)
                   .IsRequired() // Balance is required
                   .HasColumnType("decimal(18,2)"); // Ensure precision for money values

            builder.Property(x => x.Status)
                   .IsRequired() // Status is required
                   .HasMaxLength(50); // Limit the length of Status

            builder.Property(x => x.PaymentMethod)
                   .IsRequired() // PaymentMethod is required
                   .HasMaxLength(50); // Limit the length of PaymentMethod

        }
    }
}
