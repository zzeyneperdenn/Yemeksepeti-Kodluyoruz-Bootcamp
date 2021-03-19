using System;
using System.Collections.Generic;
using System.Text;

namespace HW5_Domain.CustomExceptions
{
    public class ConcurrencyException : Exception
    {
        public ConcurrencyException()
        {

        }

        public ConcurrencyException(string message) : base(message)
        {

        }

        public ConcurrencyException(string message, Exception innerException) : base(message,innerException)
        {

        }
    }
}
