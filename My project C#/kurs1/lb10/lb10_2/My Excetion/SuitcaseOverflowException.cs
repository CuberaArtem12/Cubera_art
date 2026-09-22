using lb10_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lb10_2.ServiceMethod
{
    public class SuitcaseOverflowException : Exception
    {
        public SuitcaseOverflowException(string message) : base(message) 
        {
        }
    }
}
