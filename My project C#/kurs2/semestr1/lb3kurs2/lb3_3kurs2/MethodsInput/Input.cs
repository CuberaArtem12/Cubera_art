using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb3_3kurs2.MethodsInput
{
    internal class Input
    {
        public static int ValidInputInt() {
            {
                int number;
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid input! Please enter a valid number:");
                }

                return number;
            }
        }
    }
}
