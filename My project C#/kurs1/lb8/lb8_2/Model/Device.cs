using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lb8_2.MyInteface;

namespace lb8_2.Model
{
    public class Device:IDevice<Device>,IPart, IComparable<Device>, ICloneable
    {
        public string DevName { get; protected set; }
        public float Weight { get; protected set; }
        public bool IsElectronic { get;protected set; }
        public string Material { get; protected set; }
        public Device(string devName, float weight,  string material)
        {
            DevName = devName;
            Weight = weight;
            Material = material;
        }
        public Device() {
            DevName = "unknown device";
        }
        public override string ToString() {
            return "Fly device name: " + DevName + ", Weight device tons: " + Weight +  ", \nMaterial: " + Material+" IsElectronic: " + IsElectronic;
        }
        public int CompareTo(Device other)
        {
            if (other == null) return 1;
            return string.Compare(this.DevName, other.DevName);

        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
