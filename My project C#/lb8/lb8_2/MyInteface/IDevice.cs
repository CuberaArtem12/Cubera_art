using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8_2.MyInteface
{
    public interface IDevice<T>
    {
        string DevName { get; }
        float Weight { get;  }
        Boolean IsElectronic { get; }
    }
}
