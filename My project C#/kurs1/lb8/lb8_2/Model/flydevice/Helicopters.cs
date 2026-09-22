using lb8_2.MyInteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8_2.Model.flydevice
{
    public class Helicopters : Device, IEngine
    {
        public int Power { get; set; }
        public string Model { get; set; }
        public Helicopters(string devName, float weight,  string material,int _Power, string _Model)
            :base(devName, weight, material)
        {
            Power= _Power;
            Model= _Model;
            IsElectronic = true;
        }
        public override string ToString() {
            return "(Helicopters)" + base.ToString() + "\nModel Engine: " + Model + " Power: " + Power;
        }
    }
}
