using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW4.Contexts;
using HW4.Entities;
using HW4.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace HW4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly Brand _brandEntity;
        private DatabaseContext _dbContext;

        public BrandController(IOptions<Brand> brandOptions)
        {
            _brandEntity = brandOptions.Value;
        }

        [HttpGet(Name = nameof(GetBrands))]
        [ProducesResponseType(200)]
        public ActionResult<Brand> GetBrands()
        {
            List<Brand> brands = _dbContext.Brands.ToList();
            return Ok(brands);
        }

        [HttpPost]
        public void Post([FromBody] Brand brand)
        {
            _dbContext.Brands.Add(brand);
        }

        [HttpPut("{id}")]
        public Brand Put([FromBody] Brand brands)
        {
            var editbrands = _dbContext.Brands.FirstOrDefault(x => x.Id == brands.Id);
            editbrands.Name = brands.Name;
            editbrands.Cars = brands.Cars;
            return brands;
        }

        [HttpDelete]
        public void Delete(int id)
        {
            var deleteBrand =  _dbContext.Brands.FirstOrDefault(x=>x.Id == id);
            _dbContext.Brands.Remove(deleteBrand);
        }
    }
}
