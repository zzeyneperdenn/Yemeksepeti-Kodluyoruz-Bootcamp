using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HW7_1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [ApiVersion("1.0")]
        [HttpGet(Name = nameof(GetWeathers))]
        public IActionResult GetWeathers()
        {
            List<string> weathers = new List<string>()
            {
                "It is sunny",
                "It is rainy"
            };
            return Ok(weathers);
        }

        [MapToApiVersion("1.1")]
        [HttpGet(Name = nameof(GetWeathersV2))]
        public IActionResult GetWeathersV2()
        {
            List<string> weathers = new List<string>()
            {
                "Sunny",
                "Rainy"
            };
            return Ok(weathers);
        }
    }
}

