using lb8.my_exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace lb8.Model
{
    public class Device : IComparable,ICloneable
    {
        public string Name { get; set; }
        public double Price { get; set;}
        public DateTime DataRelease { get; set; }
         public Device(string name, double price,DateTime dataRelease) {
           Name= name;
           Price= price;
           DataRelease= dataRelease;
         }
        public Device() {
            Name = "NoName";
            Price = 0;
            DataRelease = DateTime.MinValue;
        }
        public override string ToString()
        {
            return "Name: " + Name + " Price: " + Price + "\nDevice release date: " + DataRelease.ToShortDateString();
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Device OtherPrice = obj as Device;
            if (OtherPrice != null)
                return this.Price.CompareTo(OtherPrice.Price);
            else 
                throw new SetDMydException("Object is not a Price");
        }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
