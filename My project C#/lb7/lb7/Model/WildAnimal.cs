using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb7.Model
{
    public class WildAnimal
    {

        private string name;
        private string animalSpecies;
        private int age;

        public WildAnimal(string _name, int _age, string animalSpecies)
        {
            name = _name;
            age = _age;
            this.animalSpecies = animalSpecies;
        }
        public WildAnimal()
        {
            name = "NoName";
            age = 0;
            animalSpecies = "Unspecified";
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == string.Empty) throw new ArgumentOutOfRangeException();
                name = value;
            }
        }
        public string AnimalSpecies
        {
            get { return animalSpecies; }
            set
            {
                if (value == string.Empty) throw new ArgumentOutOfRangeException();
                animalSpecies = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                age = value;
            }
        }
        public override string ToString()
        {
            return " name of the animal: " + name + " Age: " + age + " animal species: " + animalSpecies;
        }
    }
}
