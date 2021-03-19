using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW4.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HW4.Configuration
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(b => b.Id).UseIdentityColumn();
            builder.Property(b => b.Name).IsRequired().HasMaxLength(50);
            builder.HasOne(m => m.Brand).WithMany(a => a.Cars).HasForeignKey(m => m.BrandId);
            builder.ToTable("Cars");
        }
    }
}
