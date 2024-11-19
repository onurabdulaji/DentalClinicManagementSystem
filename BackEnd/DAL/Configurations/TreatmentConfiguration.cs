using Entity.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class TreatmentConfiguration : BaseConfiguration<Treatment>
    {
        public override void Configure(EntityTypeBuilder<Treatment> builder)
        {
            base.Configure(builder);

            // Set the primary key for Treatment
            builder.HasKey(x => x.Id); // 'Id' is the primary key

            // Configure PatientId (required foreign key)
            builder.Property(x => x.PatientId)
                   .IsRequired(); // PatientId is required

            // Configure TreatmentName (required)
            builder.Property(x => x.TreatmentName)
                   .IsRequired() // TreatmentName is required
                   .HasMaxLength(200); // Set a max length for TreatmentName

            // Configure TreatmentDate (required)
            builder.Property(x => x.TreatmentDate)
                   .IsRequired(); // TreatmentDate is required

            // Configure Cost (required)
            builder.Property(x => x.Cost)
                   .IsRequired(); // Cost is required

            // Configure Description (optional)
            builder.Property(x => x.Description)
                   .HasMaxLength(1000); // Set a max length for Description

            // Configure IsCompleted (optional)
            builder.Property(x => x.IsCompleted)
                   .IsRequired(); // IsCompleted is required
        }
    }
}
