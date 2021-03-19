using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Week2HWW.Validation
{
    public class Copies : ValidationAttribute
    {
        private int _maxCopie;

        public Copies(int maxCopie)
        {
            _maxCopie = maxCopie;
        }

        public override bool IsValid(object value)
        {
            return (int)value < _maxCopie;
        }
    }
}
