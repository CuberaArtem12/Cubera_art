using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8_2.Model.flydevice
{
    public class HangGlider : Device
    {
        public HangGlider(string devName, float weight,  string material)
          : base(devName, weight, material)
        {

            IsElectronic = false;
        }
        public override string ToString()
        {
            return "(HangGlider)" + base.ToString();
        }
    }
}
