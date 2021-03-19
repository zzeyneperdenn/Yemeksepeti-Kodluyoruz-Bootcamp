using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Dapper;
using Week5HW.Models;
using Microsoft.Extensions.Caching.Memory;
using System.Data.SqlClient;

namespace Week5HW.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IMemoryCache _memoryCache;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMemoryCache memoryCache, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
            _memoryCache = memoryCache;
        }

        public void DatabaseConnection(IDbConnection db)
        {
            if (db.State != ConnectionState.Open)
            {
                db.Open();
            }
        }

        [HttpGet]
        public IActionResult Get()
        {

            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                DatabaseConnection(db);

                string sql = "Select * From TestTableHW";

                IEnumerable<TestModel> test;
                test = db.Query<TestModel>(sql);
            }
            return Ok();
        }

        public IActionResult Insert()
        {
            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                DatabaseConnection(db);

                string sql = @"Insert Into dbo.TestTableHW(Id, Name) Values (@Id, @Name);";

                TestModel testModel = new TestModel { Id = 1, Name = "Zeynep" };
                var affected = db.Execute(sql, testModel);

            }
            return Ok();
        }

        public IActionResult Update()
        {
            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                DatabaseConnection(db);

                string sql = @"Update dbo.TestTableHW Set Name = @Name where Id = @Id";

                var updateTest = new[]
                {
                    new { Id = 1, Name = "Zeynep"},
                    new { Id = 2, Name = "Erden"}
                };

                var affected = db.Execute(sql, updateTest);

            }
            return Ok();
        }

        public IActionResult Delete()
        {
            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                DatabaseConnection(db);

                string sql = @"Delete From dbo.TestTableHW where Id = @Id";

                var affected = db.Execute(sql, new { Id = 2 });

            }
            return Ok();
        }

        public IActionResult DeleteINQuery()
        {
            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                DatabaseConnection(db);

                string sql = @"Delete From dbo.TestTableHW where Id = @Id";

                var affected = db.Query(sql, new { Id = 2 });

            }
            return Ok();
        }

        public IActionResult TransactionalInsert()
        {
            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                DatabaseConnection(db);

                using (var transaction = db.BeginTransaction())
                {

                    string sql = @"Insert Into dbo.TestPerson (Id, Name) values (@Id, @Name);";

                    TestModel testModel = new TestModel { Id = 5, Name = "Test Name" };
                    db.Execute(sql, testModel, transaction);


                    Culture culture = new Culture { Name = "Culture Test Name", ModifiedDate = DateTime.Now };
                    sql = @"Insert into [Production].[Culture] (Name, ModifiedDate) values (@Name, @ModifiedDate);";
                    db.Execute(sql, culture, transaction);

                    transaction.Commit();
                }

            }
            return Ok();
        }

        public IActionResult OneToManyMapping()
        {
            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                DatabaseConnection(db);

                string sql = "select * from [Person].[PersonPhone] as Per Inner Join [Person].[PhoneNumberType] as Pho ON Per.PhoneNumberTypeID = Pho.PhoneNumberTypeID;";

                var personPhoneDictionary = new Dictionary<int, PersonPhone>();

                var data = db.Query<PersonPhone, PhoneNumberType, PersonPhone>(sql,
                    (personPhone, phoneNumberType) =>
                    {
                        PersonPhone personPhoneData;
                        if (!personPhoneDictionary.TryGetValue(personPhone.PhoneNumberTypeID, out personPhoneData))
                        {
                            personPhoneData = personPhone;
                            personPhoneData.PhoneNumberTypes = new List<PhoneNumberType>();
                            personPhoneDictionary.Add(personPhoneData.PhoneNumberTypeID, personPhoneData);
                        }
                        personPhoneData.PhoneNumberTypes.Add(phoneNumberType);
                        return personPhoneData;
                    },
                    splitOn: "PhoneNumberTypeID"
                ).Distinct().ToList();

                return Ok(data);
            }
        }

        public IActionResult MultipleQueryMapping()
        {
            using (var db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                DatabaseConnection(db);

                string sql = @"select * from [Production].[Product] where ProductId = @ProductID; Select * from [Production].[ProductCostHistory] where ProductId = @ProductID;";
                Product product;
                using (var multiple = db.QueryMultiple(sql, new { ProductID = 711 }))
                {
                    product = multiple.Read<Product>().First();
                    product.ProductCosts = multiple.Read<PersonPhone>().ToList();
                }
                return Ok(product);
            }

        }

    }
}
