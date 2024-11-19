using Entity.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class AppointmentConfiguration : BaseConfiguration<Appointment>
    {
        public override void Configure(EntityTypeBuilder<Appointment> builder)
        {
            base.Configure(builder);

            // Configure the Appointment entity
            builder.HasKey(a => a.Id); // Primary Key is Id

            // Configure the AppointmentDate property
            builder.Property(a => a.AppointmentDate)
                .IsRequired(); // AppointmentDate is required

            // Configure TreatmentType property
            builder.Property(a => a.TreatmentType)
                .HasMaxLength(100) // Maximum length of 100 characters for TreatmentType
                .IsRequired(); // TreatmentType is required

            // Configure Status property
            builder.Property(a => a.Status)
                .HasMaxLength(50) // Maximum length of 50 characters for Status
                .IsRequired(); // Status is required

            // Configure Notes property
            builder.Property(a => a.Notes)
                .HasMaxLength(500); // Maximum length of 500 characters for Notes

            // Configuring the relationship with Patient
            builder.HasOne(a => a.Patient) // Each Appointment has one Patient
                .WithMany(p => p.Appointments) // One Patient can have many Appointments
                .HasForeignKey(a => a.PatientId) // Foreign key from Appointment to Patient
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade); // Cascade delete for the relationship

            // Additional configurations for other relationships or validation rules can be added here if necessary

            // Configure DateOfBirth property
            builder.Property(u => u.CreatedDate)
                .IsRequired(false); // DateOfBirth is optional, but can be required if needed

            // Configure DateOfBirth property
            builder.Property(u => u.UpdatedDate)
                .IsRequired(false); // DateOfBirth is optional, but can be required if needed
        }
    }
}
