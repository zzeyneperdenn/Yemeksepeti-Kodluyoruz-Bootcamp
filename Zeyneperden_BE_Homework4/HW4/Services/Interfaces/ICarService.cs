using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW4.Entities;

namespace HW4.Services
{
    public interface ICarService
    {
        Task<IEnumerable<Car>> GetAllWithBrand();
        Task<Car> GetCarById(int id);
        Task<IEnumerable<Car>> GetCarsByBrandId(int brandId);
        Task<Car> CreateCar(Car newCar);
        Task UpdateCar(Car updateCar, Car car);
        Task DeleteCar(Car car);
    }
}
