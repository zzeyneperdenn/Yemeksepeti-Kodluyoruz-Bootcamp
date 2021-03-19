using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW4.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HW4.Contexts
{
    public class SeedData
    {
        public static async Task InitializeAsync(IServiceProvider serviceProvider)
        {
            using (var context = new DatabaseContext(
                serviceProvider.GetRequiredService<DbContextOptions<DatabaseContext>>()))
            {
                if (context.Brands.Any() && context.Cars.Any())
                {
                    return;
                }

                context.Cars.Add(new Entities.Car
                {
                    Id = 1,
                    Name = "Year 2018 Audi",
                    BrandId = 2
                });

                context.Brands.Add(new Entities.Brand
                {
                    Id = 2,
                    Name = "Audi"
                });
                //context.SaveChanges();
                await context.SaveChangesAsync();
            }
        }
    }
}
