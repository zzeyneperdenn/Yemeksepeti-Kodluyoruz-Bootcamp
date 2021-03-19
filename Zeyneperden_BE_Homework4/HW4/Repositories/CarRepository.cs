using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW4.Contexts;
using HW4.Entities;
using Microsoft.EntityFrameworkCore;

namespace HW4.Repositories
{
    public class CarRepository : RepositoryBase<Car>, ICarRepository
    {
        public CarRepository(DatabaseContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Car>> GetAllWithBrandAsync()
        {
            return await DatabaseContext.Cars.Include(b => b.Brand).ToListAsync();
        }

        public async Task<IEnumerable<Car>> GetAllWithBrandByBrandIdAsync(int brandId)
        {
            return await DatabaseContext.Cars.Include(b => b.Brand).Where(b => b.BrandId == brandId).ToListAsync();
        }

        public async Task<Car> GetWithBrandByIdAsync(int id)
        {
            return await DatabaseContext.Cars.Include(b => b.Brand)
                .SingleOrDefaultAsync(b => b.Id == id);
        }

        private DatabaseContext DatabaseContext
        {
            get { return _context as DatabaseContext; }
        }
    }
}
