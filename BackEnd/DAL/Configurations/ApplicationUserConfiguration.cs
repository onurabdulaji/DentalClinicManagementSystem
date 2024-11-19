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
    public class ApplicationUserConfiguration : BaseConfiguration<ApplicationUser>
    {
        public override void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            base.Configure(builder);

            // Configure the ApplicationUser entity
            builder.HasKey(u => u.Id); // Primary Key is Id (inherited from IdentityUser<int>)

            // Configure FullName as required
            builder.Property(u => u.FullName)
                .IsRequired()
                .HasMaxLength(200); // Full name is required with max length of 200

            // Configure Role property (if you want to store role as a string)
            builder.Property(u => u.Role)
                .HasMaxLength(50); // Max length for the Role property

            // Configure ProfilePicture property
            builder.Property(u => u.ProfilePicture)
                .HasMaxLength(500); // Max length for ProfilePicture URL/Path

            // Configure DateOfBirth property
            builder.Property(u => u.DateOfBirth)
                .IsRequired(false); // DateOfBirth is optional, but can be required if needed

            // Configure IsActive property (if the user can be deactivated)
            builder.Property(u => u.IsActive)
                .HasDefaultValue(true); // Default value for IsActive is true (active user)

            // Configure DateOfBirth property
            builder.Property(u => u.CreatedDate)
                .IsRequired(false); // DateOfBirth is optional, but can be required if needed

            // Configure DateOfBirth property
            builder.Property(u => u.UpdatedDate)
                .IsRequired(false); // DateOfBirth is optional, but can be required if needed

            // Additional custom configurations for relationships can be added here
        }
    }
}
