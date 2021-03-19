using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW8.Entities;
using Microsoft.EntityFrameworkCore;

namespace HW8.Contexts
{
    public class HotelApiDbContext : DbContext
    {
        public HotelApiDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<RoomEntity> Rooms { get; set; }
        public DbSet<UserEntity> Users { get; set; }
    }
}
