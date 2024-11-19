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
    public class ReminderConfiguration : BaseConfiguration<Reminder>
    {
        public override void Configure(EntityTypeBuilder<Reminder> builder)
        {
            base.Configure(builder);

            // Set the primary key for Reminder
            builder.HasKey(x => x.Id); // 'Id' is the primary key

            // Configure PatientId as a foreign key
            builder.HasOne(x => x.Patient) // Each Reminder is associated with one Patient
                   .WithMany(x => x.Reminders) // A Patient can have many Reminders
                   .HasForeignKey(x => x.PatientId) // Foreign key to Patient
                   .OnDelete(DeleteBehavior.Cascade); // Optional: Cascade delete when Patient is deleted

            // Configure ReminderDate (required)
            builder.Property(x => x.ReminderDate)
                   .IsRequired(); // ReminderDate is required

            // Configure Message (optional)
            builder.Property(x => x.Message)
                   .HasMaxLength(500); // Set a maximum length for the Message property

            // Configure IsCompleted (default value)
            builder.Property(x => x.IsCompleted)
                   .HasDefaultValue(false); // Default value for IsCompleted (false)
        }
    }
}
