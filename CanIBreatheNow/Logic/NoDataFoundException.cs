using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CanIBreatheNow.Logic
{
    public class NoDataFoundException : Exception
    {
        public NoDataFoundException(string message) : base(message)
        {
        }
    }
}