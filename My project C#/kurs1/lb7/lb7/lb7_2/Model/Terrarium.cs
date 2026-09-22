using lb7_2.My_enum;
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
       
        public TypeTerrarium typeTerrarium { get; set; }
        public int AnimalsCount { get
            {
                if (animals == null) return 0;
                int animalsCount = 0;
                for (int i = 0; i < animals.Length; i++)
                {
                    if (animals[i] != null)
                    {
                        animalsCount++;
                    }
                }
                return animalsCount;
             }  }
        
        public Terrarium() {

        }
        
        public Terrarium(TypeTerrarium typeTerrarium, Animal[] animals) {
            
            this.animals = animals;
            this.typeTerrarium=typeTerrarium;


        }
                public Animal[] Animals
        {
            get { return animals; }
            set { animals = value; }
        }
        
        public string AnimalList(Animal[] animals) {
            StringBuilder list = new StringBuilder();
            foreach (var animal in animals)
            {
                if (animal != null)
                {
                    list.Append(" - ")
               .Append(animal)
               .Append(" Sound: ")
               .Append(animal.MakeSound())
               .Append("\n");
                }
            }
            return list.ToString(); 
        }
        
        public override string ToString()
        {
            return "Terrarium type: " + typeTerrarium + "\nAnimal List:\n"+ AnimalList(animals);
        }

    }
}
