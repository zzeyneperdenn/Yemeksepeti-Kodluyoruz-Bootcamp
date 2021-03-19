using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW6.Entities;
using Microsoft.EntityFrameworkCore;

namespace HW6.Contexts
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base (options)
        {

        }

        public DbSet<IPEntity> WhiteList { get; set; }
    }
}
