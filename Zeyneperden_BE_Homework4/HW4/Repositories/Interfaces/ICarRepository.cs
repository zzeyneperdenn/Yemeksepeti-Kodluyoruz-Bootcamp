using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW4.Entities;

namespace HW4.Repositories
{
    public interface ICarRepository : IRepositoryBase<Car>
    {
        Task<IEnumerable<Car>> GetAllWithBrandAsync();
        Task<Car> GetWithBrandByIdAsync(int id);
        Task<IEnumerable<Car>> GetAllWithBrandByBrandIdAsync(int brandId);
    }
}
