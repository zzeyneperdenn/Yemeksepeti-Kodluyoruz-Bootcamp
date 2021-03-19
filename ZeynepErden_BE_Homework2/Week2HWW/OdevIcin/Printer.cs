using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week2HWW.Abstract;

namespace Week2HWW.OdevIcin
{
    public class Printer : Machine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Copy { get; set; }

        public override void _Machine()
        {
            Console.WriteLine("I'm a Machine");
        }
    }
}
