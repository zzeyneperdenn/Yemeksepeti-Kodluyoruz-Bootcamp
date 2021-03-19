using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HW7.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [Route("[controller]")]
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("1.1")]
    [ApiVersion("2.0")]
    public class WeatherForecastController : ControllerBase
    {
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

        [ApiVersion("1.0", Deprecated = true)]
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
