using Entity.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class ApplicationRoleConfiguration : BaseConfiguration<ApplicationRole>
    {
        public override void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            base.Configure(builder);
            // Configure the ApplicationRole entity
            builder.HasKey(r => r.Id); // Primary Key

            builder.Property(r => r.Name)
                .IsRequired() // Role Name is required
                .HasMaxLength(100); // Max length for Role Name is 100 characters

            builder.Property(r => r.Description)
                .HasMaxLength(500); // Max length for Description is 500 characters

            builder.Ignore(r => r.Id); // Ignoring Id property if you don't need it to be mapped

            // Configure DateOfBirth property
            builder.Property(u => u.CreatedDate)
                .IsRequired(false); // DateOfBirth is optional, but can be required if needed

            // Configure DateOfBirth property
            builder.Property(u => u.UpdatedDate)
                .IsRequired(false); // DateOfBirth is optional, but can be required if needed
        }
    }
}
