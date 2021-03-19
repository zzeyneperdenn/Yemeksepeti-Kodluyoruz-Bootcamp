using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Saklambac.NetCore.Database;
using Week2HWW.Data;
using Week2HWW.Data.Context;
using Week2HWW.Extensions;
using Week2HWW.Filters;
using Week2HWW.Model;

namespace Week2HWW.Properties
{
    [ApiController]
    [Route("api/[controller]")]
    public class SystemController : ControllerBase
    {
        private DbContextOptions<DatabaseContext> option;

        public SystemController()
        {
            option = new DbContextOptionsBuilder<DatabaseContext>().UseInMemoryDatabase(databaseName: "TestDatabase").Options;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<ScanPrintModel> result = new List<ScanPrintModel>();

            using (DatabaseContext dbContext = new DatabaseContext(option))
            {
                var entityList = dbContext.ScanPrints.ToList();

                result = entityList.ToScanPrints();
            }
            return Ok(result);
        }

        [HttpPost]
        [ValidationActionModel]
        public IActionResult Post([FromBody] ScanPrintModel model)
        {

            return Ok();
        }
    }
}



//var request = JsonConvert.DeserializeObject<ScanPrintModel>(JsonConvert.SerializeObject(model));

//var context = new ValidationContext(request);
//var validationResult = new List<ValidationResult>();

//bool isValid = Validator.TryValidateObject(request, context, validationResult, true);
//if (!isValid)
//    return BadRequest(validationResult);