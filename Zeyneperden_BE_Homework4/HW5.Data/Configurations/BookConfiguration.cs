using System;
using System.Collections.Generic;
using System.Text;
using HW5.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HW5.Core.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(b => b.Id).UseIdentityColumn();
            builder.Property(b => b.Name).IsRequired().HasMaxLength(50);
            builder.Property(b => b.Topic).IsRequired().HasMaxLength(50);
            builder.HasOne(b => b.Topic).WithMany(t => t.Books).HasForeignKey(b => b.TopicId);
            builder.ToTable("Topics");
        }
    }
}
