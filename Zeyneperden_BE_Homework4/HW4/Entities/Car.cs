using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW4.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}
