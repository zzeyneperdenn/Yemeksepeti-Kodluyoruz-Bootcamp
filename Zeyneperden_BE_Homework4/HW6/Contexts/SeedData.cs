using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace HW6.Contexts
{
    public static class SeedData
    {
        public static async Task InitializeAsync(IServiceProvider service)
        {
            await AddSampleData(service.GetRequiredService<DatabaseContext>());
        }

        public static async Task AddSampleData(DatabaseContext dbContext)
        {
            if (!dbContext.WhiteList.Any())
            {
                dbContext.WhiteList.Add(new Entities.IPEntity
                {
                    IPAddress = "192.168.1.1"
                });

                dbContext.WhiteList.Add(new Entities.IPEntity
                {
                    IPAddress = "192.168.1.2"
                });
            }

            await dbContext.SaveChangesAsync();
        }
    }
}
