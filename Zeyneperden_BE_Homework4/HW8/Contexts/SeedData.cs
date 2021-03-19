using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW8.Contexts
{
    public static class SeedData
    {
        public static async Task AddSampleData(HotelApiDbContext dbContext)
        {
            if (!dbContext.Rooms.Any())
            {
                dbContext.Rooms.Add(new Entities.RoomEntity
                {
                    Id = Guid.Parse("d1872b3e-f933-4c28-9199-2544122ac527"),
                    Name = "Basic Room",
                    Rate = 345678,
                    IsMigrate = false
                });

                dbContext.Rooms.Add(new Entities.RoomEntity
                {
                    Id = Guid.Parse("49d405f1-1134-4da8-b203-1c5b732cb2df"),
                    Name = "Suit Room",
                    Rate = 345678,
                    IsMigrate = false
                });
            }

            if (!dbContext.Users.Any())
            {
                dbContext.Users.Add(new Entities.UserEntity
                {
                    Id = 1,
                    Name = "Zeynep",
                    SurName = "Erden",
                    LoginName = "kebelek",
                    Password = "1234",
                    Phone = "053412342342"
                });
            }
            await dbContext.SaveChangesAsync();
        }
    }
}
