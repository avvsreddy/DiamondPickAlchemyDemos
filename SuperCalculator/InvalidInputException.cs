using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCalculator
{
    public class InvalidInputException : ApplicationException
    {
        public InvalidInputException(string msg = null, Exception exception = null) : base(msg,exception)
        {

        }
    }
}
