using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb11.Service
{
    public class RecalculateCount
    {
        public static int CurCount(object[] items)
        {
            int total = 0;
            foreach (var item in items)
            {
                if (item != null) total ++;
            }
            return total;
        }
    }
}
