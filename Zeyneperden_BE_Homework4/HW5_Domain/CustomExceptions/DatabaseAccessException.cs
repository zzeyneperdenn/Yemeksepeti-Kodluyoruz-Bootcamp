using System;
using System.Collections.Generic;
using System.Text;

namespace HW5_Domain.CustomExceptions
{
    public class DatabaseAccessException : Exception
    {
        public DatabaseAccessException()
        {

        }

        public DatabaseAccessException(string message) : base(message)
        {

        }

        public DatabaseAccessException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
