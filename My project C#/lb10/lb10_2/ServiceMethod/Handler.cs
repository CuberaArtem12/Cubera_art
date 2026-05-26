using lb10_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb10_2.ServiceMethod
{
    public class Handler
    {
        public static void Masage(Item item) {
            throw new SuitcaseOverflowException($"Not enough suitcase space for {item.name}");
        }
    }
}
