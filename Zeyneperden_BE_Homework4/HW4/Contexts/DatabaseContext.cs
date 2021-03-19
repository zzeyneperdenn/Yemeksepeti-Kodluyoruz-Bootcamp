using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW4.Configuration;
using HW4.Entities;
using Microsoft.EntityFrameworkCore;

namespace HW4.Contexts
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CarConfiguration());

            builder.ApplyConfiguration(new BrandConfiguration());
        }
    }
}
