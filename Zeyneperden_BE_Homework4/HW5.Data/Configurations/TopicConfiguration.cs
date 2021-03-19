using System;
using System.Collections.Generic;
using System.Text;
using HW5.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HW5.Core.Configurations
{
    class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).UseIdentityColumn();
            builder.Property(b => b.Name).IsRequired().HasMaxLength(50);
            builder.ToTable("Books");
        }
    }
}
