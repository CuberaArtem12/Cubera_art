using lb7_2.my_exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace lb7_2.Model
{
    public class Terrarium
    {
        public static int maximumcapacity = 10;
        public Animal[] animals = new Animal[maximumcapacity];
        private int animalsCount = 0;
        public int AnimalsCount { get { return animalsCount; } 
        set { animalsCount = value; }
        }
        public Terrarium() {

        }
        public Terrarium( Animal[] animals) {
            
            this.animals = animals;
            
        }
        
        public Animal[] Animals
        {
            get { return animals; }
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
        public string AnimalList(Animal[] animals) {
            StringBuilder list = new StringBuilder();
            foreach (var animal in animals)
            {
                list.Append(" - ")
               .Append(animal)
               .Append(" Sound: ")
               .Append(animal.MakeSound())
               .Append("\n");
            }
            return list.ToString(); 
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
            return "\nAnimal List:\n"+ AnimalList(animals) +"Food in month: "+ TotalamountFoodMonth();
        }

    }
}
