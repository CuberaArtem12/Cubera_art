using lb8_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8_2.Service
{
    public class ServiceSort
    {
        public void SortName(Device[] deviceslist ) {
        Array.Sort( deviceslist );
        }
        public void SortWeight(Device[] deviceslist) {
            Array.Sort( deviceslist, (x, y) => x.Weight.CompareTo(y.Weight));
        }
    }
}
