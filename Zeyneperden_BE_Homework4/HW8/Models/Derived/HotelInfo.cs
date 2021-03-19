using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW8.Abstract;

namespace HW8.Models.Derived
{
    public class HotelInfo : Resource
    {
        public string Title { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public HotelAddress Location { get; set; }
    }
}
