using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomMiddleWare.Data.Entities;
using CustomMiddleWare.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HW2_0.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IRepositoryBase<Weather> _repository;

        public WeatherForecastController(IRepositoryBase<Weather> repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var weathers = await _repository.GetAllAsync();
            return Ok(weathers);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var weather = await _repository.GetByIdAsync(id);
            return Ok(weather);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Weather weather)
        {
            await _repository.AddAsync(weather);
            return Created(string.Empty, weather);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Weather weather)
        {
            _repository.Update(weather);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var weather = await _repository.GetByIdAsync(id);
            _repository.Remove(weather);
            return NoContent();
        }
    }
}
