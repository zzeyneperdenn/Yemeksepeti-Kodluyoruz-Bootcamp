using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW4.Entities;

namespace HW4.Services
{
    public class CarService : ICarService
    {
        public Task<Car> CreateCar(Car newCar)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCar(Car car)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Car>> GetAllWithBrand()
        {
            throw new NotImplementedException();
        }

        public Task<Car> GetCarById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Car>> GetCarsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCar(Car updateCar, Car car)
        {
            throw new NotImplementedException();
        }
    }
}
