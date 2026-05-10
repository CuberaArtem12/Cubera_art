using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb7_2.my_exception
{
    internal class SetDBirthdException : ApplicationException
    {
        public string Message { get; set; }
        public SetDBirthdException(string mes)
        {
            Message = mes;
        }
    }
}
