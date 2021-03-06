using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HW6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ServiceFilter(typeof(IPControlAttribute))]
    public class AuthController : ControllerBase
    {
        [HttpGet(Name = nameof(GetAuth))]
        public IEnumerable<string> GetAuth()
        {
            return new List<string>
            {
                "home",
                "customer"
            };
        }
    }
}
