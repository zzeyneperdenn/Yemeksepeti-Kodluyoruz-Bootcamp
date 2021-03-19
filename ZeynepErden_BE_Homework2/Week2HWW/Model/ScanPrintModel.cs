using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Week2HWW.Abstract;

namespace Week2HWW.Model
{
    public class ScanPrintModel : Machine, IScan, IPrint
    {
        [Required(ErrorMessage = "Please enter an Id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        [Range(0, 100, ErrorMessage = "You can have max 100 copies")]
        public int Copy { get; set; }

        public override void _Machine()
        {
            Console.WriteLine("I'm a Machine");
        }

        public void _Print()
        {
            Console.WriteLine("I can print");
        }

        public void _Scan()
        {
            Console.WriteLine("I can scan");
        }
    }
}
