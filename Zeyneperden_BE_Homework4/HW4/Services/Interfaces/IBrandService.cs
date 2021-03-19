using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW4.Entities;

namespace HW4.Services
{
    public interface IBrandService
    {
        Task<IEnumerable<Brand>> GetAllBrands();
        Task<Brand> GetBrandById(int id);
        Task<Brand> CreateBrand(Brand newBrand);
        Task UpdateBrand(Brand updateBrand, Brand brand);
        Task DeleteBrand(Brand brand);
    }
}
