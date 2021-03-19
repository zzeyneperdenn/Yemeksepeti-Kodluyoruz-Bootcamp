using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week5HW.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public virtual List<PersonPhone> ProductCosts { get; set; }
    }
}
