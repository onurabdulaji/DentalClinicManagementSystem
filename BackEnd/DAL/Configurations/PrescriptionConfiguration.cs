using Entity.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class PrescriptionConfiguration : BaseConfiguration<Prescription>
    {
        public override void Configure(EntityTypeBuilder<Prescription> builder)
        {
            base.Configure(builder);

            // Set the primary key for Prescription
            builder.HasKey(x => x.Id); // 'Id' is the primary key

            // Configure PatientId as a foreign key
            builder.HasOne(x => x.Patient) // Each Prescription is associated with one Patient
                   .WithMany(x => x.Prescriptions) // A Patient can have many Prescriptions
                   .HasForeignKey(x => x.PatientId) // Foreign key to Patient
                   .OnDelete(DeleteBehavior.Cascade); // Optional: Cascade delete when Patient is deleted

            // Configure IssueDate (required)
            builder.Property(x => x.IssueDate)
                   .IsRequired(); // IssueDate is required

            // Configure MedicationName (required)
            builder.Property(x => x.MedicationName)
                   .IsRequired()
                   .HasMaxLength(255); // Maximum length for MedicationName

            // Configure Dosage (optional)
            builder.Property(x => x.Dosage)
                   .HasMaxLength(255); // Maximum length for Dosage

            // Configure Duration (optional)
            builder.Property(x => x.Duration)
                   .HasMaxLength(255); // Maximum length for Duration

            // Configure Notes (optional)
            builder.Property(x => x.Notes)
                   .HasMaxLength(500); // Maximum length for Notes
        }
    }
}
