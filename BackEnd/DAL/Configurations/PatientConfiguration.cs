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
    public class PatientConfiguration : BaseConfiguration<Patient>
    {
        public override void Configure(EntityTypeBuilder<Patient> builder)
        {
            base.Configure(builder);

            // Set the primary key for Patient
            builder.HasKey(x => x.Id); // The primary key is 'Id'

            // Configure FirstName as required and with a max length
            builder.Property(x => x.FirstName)
                   .IsRequired() // First name is required
                   .HasMaxLength(100); // Maximum length for First Name

            // Configure LastName as required and with a max length
            builder.Property(x => x.LastName)
                   .IsRequired() // Last name is required
                   .HasMaxLength(100); // Maximum length for Last Name

            // Configure DateOfBirth
            builder.Property(x => x.DateOfBirth)
                   .IsRequired(); // Date of birth is required

            // Configure PhoneNumber as optional and with a max length
            builder.Property(x => x.PhoneNumber)
                   .HasMaxLength(15); // Maximum length for Phone Number (assuming format like +1-123-456-7890)

            // Configure the Invoices relationship (assuming a one-to-many relationship)
            builder.HasMany(x => x.Invoices) // A patient can have many invoices
                   .WithOne(x => x.Patient) // Each invoice belongs to one patient
                   .HasForeignKey(x => x.PatientId) // Foreign key to Patient in Invoice table
                   .OnDelete(DeleteBehavior.Cascade); // Optional: Cascade delete for related invoices when a patient is deleted

        }
    }
}
