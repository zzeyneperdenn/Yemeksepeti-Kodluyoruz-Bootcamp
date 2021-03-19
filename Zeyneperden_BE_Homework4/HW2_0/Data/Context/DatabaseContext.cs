using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomMiddleWare.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomMiddleWare.Data.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Weather> Weathers { get; set; }
    }
}
