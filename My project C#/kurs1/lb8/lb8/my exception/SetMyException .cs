using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8.my_exception
{
    public class SetDMydException : ApplicationException
    {
        public string Message { get; set; }
        public SetDMydException(string mes)
        {
            Message = mes;
        }
    }
}
