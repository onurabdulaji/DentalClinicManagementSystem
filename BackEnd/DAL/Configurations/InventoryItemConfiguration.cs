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
    public class InventoryItemConfiguration : BaseConfiguration<InventoryItem>
    {
        public override void Configure(EntityTypeBuilder<InventoryItem> builder)
        {
            base.Configure(builder);
            // Set the primary key for InventoryItem
            builder.HasKey(x => x.Id);

            // Configure Name: Required with a max length of 200
            builder.Property(x => x.Name)
                .IsRequired() // This field is required
                .HasMaxLength(200); // Limit the length of the name

            // Configure Description: Optional with a max length of 500
            builder.Property(x => x.Description)
                .HasMaxLength(500); // Limit the length of the description (optional)

            // Configure UnitPrice: Required and specify decimal precision (e.g., two decimal places)
            builder.Property(x => x.UnitPrice)
                .IsRequired() // This field is required
                .HasColumnType("decimal(18,2)"); // Precision of 18 digits, with 2 decimal places for prices

            // Configure QuantityInStock: Required
            builder.Property(x => x.QuantityInStock)
                .IsRequired(); // QuantityInStock is required

            // Configure IsActive: Optional, defaults to true if not provided
            builder.Property(x => x.IsActive)
                .IsRequired() // This field is required
                .HasDefaultValue(true); // Default value set to true
        }
    }
}
