using lb9_3.Enum1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb9_3.MyStruct
{
    public struct Item
    {
        public string Name;
        public int Cost;
        public decimal Price;
        public Quality quality;
        public TypeFight typefight;
        public Item(string Name, int Cost, decimal Price, Quality quality, TypeFight typefight) { 
            this.Name = Name;
            this.Cost = Cost;
            this.Price = Price;
            this.quality = quality;
            this.typefight = typefight;
        }
    }
}
