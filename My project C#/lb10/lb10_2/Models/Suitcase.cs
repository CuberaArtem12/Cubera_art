using lb10_2.My_enum;
using lb10_2.ServiceMethod;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace lb10_2.Models
{
    public delegate void SuitcaseHandler(Item item);
    public class Suitcase
    {
        public float Weight { get; set; }
        public int MaxVolume { get; set; }
        public string ManufacturerCompany { get; set; }
        public Colors ColorSuitcase { get; set; }
        public Item[] items = new Item[0];
        public Suitcase()
        {
            ManufacturerCompany = "undefined";
            MaxVolume = 30; 
            Weight = 0.0f;
            ColorSuitcase = Colors.Red;

        }
        public Suitcase(string ManufacturerCompany, float Weight,int MaxVolume, Colors ColorSuitcase) { 
        this.ManufacturerCompany = ManufacturerCompany;
            this.Weight = Weight;
            this.MaxVolume = MaxVolume;
            this.ColorSuitcase= ColorSuitcase;

        }
        public event SuitcaseHandler? OnItemAdding;
        public void AddItemInSuitcase(Item item) {
            if (item == null) return;
            int curVolume=RecalculateVolume.CurVolume(items);
            if (curVolume + item.volume > MaxVolume)
            {
                OnItemAdding?.Invoke(item);

            }
            Item[] newDrvices = new Item[items.Length + 1];
            Array.Copy(items, 0, newDrvices, 0, items.Length);
            newDrvices[newDrvices.Length - 1] = item;
            Weight += item.weight;
            this.items = newDrvices;
        }
        public string itemsListinSuicase(Item[] items)
        {
            StringBuilder list = new StringBuilder();
            foreach (var item in items)
            {
                if (item != null)
                {
                    list.Append(" - ")
               .Append(item)
               .Append("\n");
                }
            }
            return list.ToString();
        }
        public override string ToString() {
            return "===Suitcase===\n" + "Manufacturer Company: " + ManufacturerCompany + " Weight: " + Weight + "Kg "+" Volume: "+ RecalculateVolume.CurVolume(items)+$" with {MaxVolume}" +" Color: " + ColorSuitcase + "\n===items list===\n"+ itemsListinSuicase(items);
        }
    }
}
