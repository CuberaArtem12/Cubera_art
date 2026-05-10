using lb7_2.my_exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace lb7_2.Model
{
    internal class Terrarium
    {
        public string name { get; set; }
        private Animal[] animals;
        
        public Terrarium() {
            name = "NoName";
            animals=new Animal[0];
        }
        public Terrarium(string name, Animal[] animals) {
            this.name = name;
            this.animals = animals;
            
        }
        
        public Animal[] Animals {
        get { return animals; }
            set {
                if (value == null) throw new SetDBirthdException("no less than zero");
                animals = value; }
        }

        public int TotalamountFoodMonth()
        {
            int FoodMonth = 0;
            for (int i = 0; i < animals.Length; i++)
            {
                FoodMonth += animals[i].AmountFoodMonth;
            }
            return FoodMonth;
            
        
        }
        public string AnimalList() {
            string list = "";
            foreach (var animal in animals)
            {
                list += " - " + animal+ "\n";
            }
            return list;
        }
        public void AddAnimals(params Animal[] Newanimals)
        {
            Animal[] Updateanimals=new Animal[animals.Length+ Newanimals.Length];
            for (int i = 0; i < Updateanimals.Length; i++) {
                Updateanimals[i] = animals[i];
            }
            for (int i = 0; i < Newanimals.Length; i++)
            {
                Updateanimals[animals.Length + i] = Newanimals[i];
            }
            this.animals = Updateanimals;
        }
        public override string ToString()
        {
            return "Name: "+name+"\nAnimal List:\n"+ AnimalList()+"Food in month: "+ TotalamountFoodMonth();
        }

    }
}
