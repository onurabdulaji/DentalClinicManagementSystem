using Entity.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class ClinicSettingConfiguration : BaseConfiguration<ClinicSetting>
    {
        public override void Configure(EntityTypeBuilder<ClinicSetting> builder)
        {
            base.Configure(builder);

            // Configure the ClinicSetting entity
            builder.HasKey(c => c.Id); // Primary Key is Id

            builder.Property(c => c.ClinicName)
                .IsRequired() // ClinicName is required
                .HasMaxLength(200); // Maximum length of 200 characters for ClinicName

            builder.Property(c => c.Address)
                .IsRequired() // ClinicAddress is required
                .HasMaxLength(500); // Maximum length of 500 characters for ClinicAddress

            builder.Property(c => c.ContactNumber)
                .IsRequired() // ContactNumber is required
                .HasMaxLength(20); // Maximum length of 20 characters for ContactNumber

            builder.Property(c => c.Email)
                .IsRequired() // Email is required
                .HasMaxLength(100); // Maximum length of 100 characters for Email
        }
    }
}
