using Entity.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class TreatmentPlanConfiguration : BaseConfiguration<TreatmentPlan>
    {
        public override void Configure(EntityTypeBuilder<TreatmentPlan> builder)
        {
            base.Configure(builder);

            // Set the primary key for TreatmentPlan
            builder.HasKey(x => x.Id); // 'Id' is the primary key

            // Configure PatientId (required foreign key)
            builder.Property(x => x.PatientId)
                   .IsRequired(); // PatientId is required

            // Configure PlanName (required)
            builder.Property(x => x.PlanName)
                   .IsRequired() // PlanName is required
                   .HasMaxLength(200); // Set a max length for PlanName

            // Configure StartDate (required)
            builder.Property(x => x.StartDate)
                   .IsRequired(); // StartDate is required

            // Configure EndDate (required)
            builder.Property(x => x.EndDate)
                   .IsRequired(); // EndDate is required

            // Configure Description (optional)
            builder.Property(x => x.Description)
                   .HasMaxLength(1000); // Set a max length for Description

            // Configure EstimatedCost (required)
            builder.Property(x => x.EstimatedCost)
                   .IsRequired(); // EstimatedCost is required

            // Configure IsCompleted (optional)
            builder.Property(x => x.IsCompleted)
                   .IsRequired(); // IsCompleted is required
        }
    }
}
