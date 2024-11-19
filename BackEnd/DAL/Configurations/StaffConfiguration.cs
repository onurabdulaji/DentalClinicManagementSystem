using Entity.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class StaffConfiguration : BaseConfiguration<Staff>
    {
        public override void Configure(EntityTypeBuilder<Staff> builder)
        {
            base.Configure(builder);

            // Set the primary key for Staff
            builder.HasKey(x => x.Id); // 'Id' is the primary key

            // Configure FirstName (required)
            builder.Property(x => x.FirstName)
                   .IsRequired() // FirstName is required
                   .HasMaxLength(100); // Set a max length for FirstName

            // Configure LastName (required)
            builder.Property(x => x.LastName)
                   .IsRequired() // LastName is required
                   .HasMaxLength(100); // Set a max length for LastName

            // Configure Role (required)
            builder.Property(x => x.Role)
                   .IsRequired() // Role is required
                   .HasMaxLength(50); // Set a max length for Role

            // Configure Email (required and unique)
            builder.Property(x => x.Email)
                   .IsRequired() // Email is required
                   .HasMaxLength(200); // Set a max length for Email
            builder.HasIndex(x => x.Email).IsUnique(); // Ensure Email is unique

            // Configure PhoneNumber (optional)
            builder.Property(x => x.PhoneNumber)
                   .HasMaxLength(20); // Set a max length for PhoneNumber

            // Configure Salary (required)
            builder.Property(x => x.Salary)
                   .IsRequired(); // Salary is required

            // Configure HireDate (required)
            builder.Property(x => x.HireDate)
                   .IsRequired(); // HireDate is required

            // Configure Qualifications (optional)
            builder.Property(x => x.Qualifications)
                   .HasMaxLength(500); // Set a max length for Qualifications
        }
    }
}
