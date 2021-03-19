using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Week2HWW.Model;

namespace Week2HWW.Data.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<ScanPrint> ScanPrints { get; set; }
        public DbSet<Printer> Printers { get; set; }
        public DbSet<Scanner> Scanners { get; set; }
    }
}
