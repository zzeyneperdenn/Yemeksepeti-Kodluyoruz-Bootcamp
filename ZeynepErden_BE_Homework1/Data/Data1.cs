using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Saklambac.NetFramework.Database;
using Week1HW.Model;

namespace Week1HW.Data
{
    public class Data1
    {
        public List<ProductModel> products = new List<ProductModel>();

        SaklambacDb<ProductModel> saklambacDb = new SaklambacDb<ProductModel>();

        //public Data1()
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        products.Add(new ProductModel { Id = i, Name = "Product-" + i, Price = (i * 10) });
        //    }
        //}
    }
}
