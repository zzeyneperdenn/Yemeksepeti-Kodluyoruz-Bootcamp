using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW4.Contexts;
using HW4.Entities;
using Microsoft.EntityFrameworkCore;

namespace HW4.Repositories
{
    public class BrandRepository : RepositoryBase<Brand>, IBrandRepository
    {
        public BrandRepository(DatabaseContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Brand>> GetAllWithCarsAsync()
        {
            return await DatabaseContext.Brands.Include(t => t.Cars).ToListAsync();
        }

        public Task<Brand> GetWithCarsByIdAsync(int id)
        {
            return DatabaseContext.Brands.Include(t => t.Cars).SingleOrDefaultAsync(t => t.Id == id);
        }

        private DatabaseContext DatabaseContext
        {
            get { return _context as DatabaseContext; }
        }
    }
}
