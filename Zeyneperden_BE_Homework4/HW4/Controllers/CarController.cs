using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW4.Contexts;
using HW4.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace HW4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly Car _carEntity;
        private DatabaseContext _dbContext;

        public CarController(IOptions<Car> carOptions)
        {
            _carEntity = carOptions.Value;
        }

        [HttpGet(Name = nameof(GetCars))]
        [ProducesResponseType(200)]
        public ActionResult<Car> GetCars()
        {
            List<Car> cars = _dbContext.Cars.ToList();
            return Ok(cars);
        }

        [HttpPost]
        public void Post([FromBody] Car car)
        {
            _dbContext.Cars.Add(car);
        }

        [HttpPut("{id}")]
        public Car Put([FromBody] Car cars)
        {
            var editCars = _dbContext.Cars.FirstOrDefault(x => x.Id == cars.Id);
            editCars.Name = cars.Name;
            editCars.BrandId = cars.BrandId;
            editCars.Brand = cars.Brand;
            return cars;
        }

        [HttpDelete]
        public void Delete(int id)
        {
            var deleteCar = _dbContext.Cars.FirstOrDefault(x => x.Id == id);
            _dbContext.Cars.Remove(deleteCar);
        }
    }
}
