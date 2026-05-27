using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb10_3.Methods
{
    public class StringMethods
    {
        public static Func<string,string,bool> CheckWordInText=(text, word) =>text.Contains(word, StringComparison.OrdinalIgnoreCase);
    }
}
