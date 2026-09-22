using lb7_2.Service;
using lb7_2.Model;
using lb7_2.My_enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb7_2.Model
{
    public class Zoo
    {
        public string name { get; set; }
        private Terrarium[] terrariumList { get; set; }= new Terrarium[maximumcapacity];
        public static int maximumcapacity = 6;
        public Zoo() {
            name = "NoName";
          
        }
        public Zoo(string name, Terrarium[] terrariumList) { 
        this.name = name;
           this.terrariumList= terrariumList;
        }
        public void AddAnimalsTerraium(params Animal[] Animals) {
            var svc = new ServiceAddAnimalTerrarium();
            foreach (var animal in Animals) {
                bool placed=false;
                TypeTerrarium needTypeTerarium=0;
                switch (animal.Type)
                {
                    case "Bugs":
                        needTypeTerarium = TypeTerrarium.TerrariumBugs;
                        break;
                    case "Snaker":
                        needTypeTerarium = TypeTerrarium.TerrariumSnaker;
                        
                        break;
                    case "Spider":
                        needTypeTerarium = TypeTerrarium.TerrariumSpider;
                        break;

                }
                bool place = false;
                for (int i = 0; i < terrariumList.Length; i++) {
                    if (terrariumList[i] == null) continue;
                    if (terrariumList[i].typeTerrarium == needTypeTerarium) {
                        int freespace = Terrarium.maximumcapacity - terrariumList[i].AnimalsCount;
                        if (freespace >0)
                        {
                            svc.AddAnimals(terrariumList[i], animal);
                            placed = true;
                            break;
                        }
                    }
                  
                }
                if (!placed) { Console.WriteLine($"there is no terrarium for these animals{animal.Name}, {animal.Type}"); }
            
            }
        
        }
        public void ShowTerarium() {
            Console.WriteLine("=====AllTerariums=====");
            foreach (var terarium in terrariumList) {
                if (terarium != null) {
                    Console.WriteLine($"{terarium.ToString()}\n");
                }
            }
        }

        public int TotalFoodInMoth() {
            int total = 0;
            for (int i = 0; i < terrariumList.Length; i++) {
                if (terrariumList[i] != null)
                    foreach (var animal in terrariumList[i].Animals) { 
                    if(animal!=null)
                            total+=animal.AmountFoodMonth;
                    }
            }
            return total;
        }
    }
}
