using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lb1kurs2_1.Valid
{
    public class ValidService
    {
        public static bool Validindex(int givennumber, int numberCheck ) {
            if (givennumber < 0 || givennumber >= numberCheck)
            {
                Console.WriteLine("There is no such index.");
                return false;
            }
            return true;
        }
    }
}
