using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : class
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            // Apply common conventions if needed
            builder.Property("CreatedDate") // Example: common property name for CreatedDate
                .HasDefaultValueSql("GETDATE()") // Default value to current date/time
                .IsRequired(false); // Optionally make it nullable

            builder.Property("UpdatedDate") // Example: common property name for UpdatedDate
                .IsRequired(false); // Optionally make it nullable
        }
    }
}
