using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW8.Entities;

namespace HW8.Models.Derived
{
    public class Room : RoomEntity
    {
        public string Name { get; set; }
        public int Rate { get; set; }
    }
}
