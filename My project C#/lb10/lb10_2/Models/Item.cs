using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb10_2.Models
{
    

    public class Item
    {
        public string name { get; set; }
        public int volume { get; set; }
        public float weight { get; set; }
        public Item() {
            name = "undefined";
            volume = 0;
            weight = 0.0f;
        }
        public Item(string name, int volume,float weight) {
        this.name = name;
            this.volume = volume;
            this.weight = weight;
        }
        public override string ToString() {
            return "Name: " + name + " Weight: " + weight + "Kg " + "Volume: " + volume;
        }
    }
}
