using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW4.Entities;

namespace HW4.Repositories
{
    public interface IBrandRepository : IRepositoryBase<Brand>
    {
        Task<IEnumerable<Brand>> GetAllWithCarsAsync();
        Task<Brand> GetWithCarsByIdAsync(int id);
    }
}
