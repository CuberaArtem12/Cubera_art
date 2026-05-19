using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lb9_3.myInterface;
using lb9_3.MyStruct;
namespace lb9_3.Model
{
    public class Armory: IService<Item>
    {
       public Item[] items;
       public int count;
       public Armory(Item[] item, int count)
        {
            this.items = item;
            this.count = count;
        }
        public void Add(Item element)
        {
            if (element.Name == null) return;
            Item[] newItems = new Item[items.Length + 1];
            Array.Copy(items, 0, newItems, 0, items.Length);
            newItems[newItems.Length - 1] = element;
            this.items = newItems;
            count = items.Length;

        }
        public void Delete(Item element) {
            int elIndexDlete = -1;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Name == element.Name)
                {
                    elIndexDlete = i;
                    break;
                }
            }
            if (elIndexDlete == -1)
            {
                Console.WriteLine("noting Devices");
                return;
            }
            Item[] DrvicesNooneDevice = new Item[items.Length - 1];
            Array.Copy(items, 0, DrvicesNooneDevice, 0, elIndexDlete);
            Array.Copy(items, elIndexDlete + 1, DrvicesNooneDevice, elIndexDlete, items.Length - elIndexDlete - 1);
            this.items = DrvicesNooneDevice;
            count= items.Length;
        }
        public bool Update(string nameToFind, Item element) {
         for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Name == nameToFind)
                {
                    items[i] = element;

                    Console.WriteLine($"Item: {nameToFind} updated to: {element.Name}");
                    return true;
                }
            }
            Console.WriteLine($"Error: Item {nameToFind} not found");
            return false;

        }
    }
}
