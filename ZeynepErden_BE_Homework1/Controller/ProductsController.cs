using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Saklambac.NetFramework.Database;
using Week1HW.Data;
using Week1HW.Model;

namespace Week1HW.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly Data1 _data1;

        SaklambacDb<ProductModel> saklambacDb = new SaklambacDb<ProductModel>();

        public ProductsController(Data1 data1)
        {
            _data1 = data1;
        }

        [HttpGet]
        public List<ProductModel> Get()
        {
            //return _data1.products;
            var list = saklambacDb.GetAll();
            return list;
        }

        [HttpGet("{productNo}")]
        public ProductModel Get(int productNo)
        {
            //var data = _data1.products.FirstOrDefault(i => i.Id == id);
            //return data;
            var dataA = saklambacDb.GetAll().FirstOrDefault(i => i.ProductNo == productNo);
            return dataA;
        }

        [HttpPost]
        public void Post([FromBody] ProductModel product)
        {
            _data1.products.Add(product);
            saklambacDb.Add(product);
        }

        [HttpPut]
        public void Put([FromBody] ProductModel product)
        {
            //var data =_data1.products.FirstOrDefault(i => i.Id == product.Id);
            //data = product;
            //_data1.products.Remove(data);
            //_data1.products.Add(product);

            var dataA = saklambacDb.GetAll().FirstOrDefault(i => i.ProductNo == product.ProductNo);
            dataA = product;
            saklambacDb.Delete(dataA);
            saklambacDb.Add(product);
        }

        [HttpDelete]
        public void Delete(ProductModel product)
        {
            //var prod = _data1.products.FirstOrDefault(x => x.Id == product.Id);
            //_data1.products.Remove(prod);
            var prodA = saklambacDb.GetAll().FirstOrDefault(i => i.ProductNo == product.ProductNo);
            saklambacDb.Delete(prodA);


        }
    }
}
