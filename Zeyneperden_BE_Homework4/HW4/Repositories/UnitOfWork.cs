using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW4.Contexts;

namespace HW4.Repositories.Interfaces
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private CarRepository _carRepository;
        private BrandRepository _brandRepository;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }
        public ICarRepository Cars => _carRepository = _carRepository ?? new CarRepository(_context);

        public IBrandRepository Brands => _brandRepository = _brandRepository ?? new BrandRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
