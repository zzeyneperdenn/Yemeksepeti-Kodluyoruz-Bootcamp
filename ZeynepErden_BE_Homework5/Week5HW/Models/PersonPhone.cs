using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week5HW.Models
{
    public class PersonPhone
    {
        public int BusinessEntityID { get; set; }
        public string PhoneNumber { get; set; }
        public int PhoneNumberTypeID { get; set; }
        public DateTime ModifiedDate { get; set; }
        public virtual List<PhoneNumberType> PhoneNumberTypes { get; set; }
    }
}
