using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace HW4.Entities
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Brand()
        {
            Cars = new Collection<Car>();
        }
        public ICollection<Car> Cars { get; set; }

    }
}
