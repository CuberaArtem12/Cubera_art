using lb10_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb10_2.ServiceMethod
{
    public class Handler
    {
        public static void Erors(Item item) {
            throw new SuitcaseOverflowException($"Not enough suitcase space for {item.name}");
        }
        public static void Message(Item item) {
            Console.WriteLine($"Add object {item.name}");
        }
    }
}
