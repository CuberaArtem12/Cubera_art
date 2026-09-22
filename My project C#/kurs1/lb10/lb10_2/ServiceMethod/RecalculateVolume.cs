using lb10_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb10_2.ServiceMethod
{
    public class RecalculateVolume
    {
        public static int CurVolume(Item[] items) {
            int total = 0;
            foreach (var item in items)
            {
                if (item != null) total += item.volume;
            }
            return total;
        }
    }
}
