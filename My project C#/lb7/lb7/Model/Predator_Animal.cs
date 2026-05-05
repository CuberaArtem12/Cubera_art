using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb7.Model
{
        internal class Predator_Animal : WildAnimal
        {
            private string location;
            private int averageNumrAnim;
            private float coefficient;
            public Predator_Animal(string _name, int _age, string animalSpecies, string _location, int _averageNumrAnim, float _coefficient) : base(_name, _age, animalSpecies)
            {
                location = _location;
                averageNumrAnim = _averageNumrAnim;
                coefficient = _coefficient;
            }
            public string Location
            {
                get { return location; }
                set
                {
                    if (value == string.Empty) throw new ArgumentOutOfRangeException();
                    location = value;
                }
            }
            public int AverageNumrAnim
            {
                get { return averageNumrAnim; }
                set
                {
                    if (value < 0) throw new ArgumentOutOfRangeException();
                    averageNumrAnim = value;
                }
            }
            public float Coefficient
            {
                get { return coefficient; }
                set
                {
                    if (value < 0) throw new ArgumentOutOfRangeException();
                    coefficient = value;
                }
            }
            public bool survivalSuccess()
            {
                return averageNumrAnim * coefficient > 100 ? true : false;
            }
            public override string ToString()
            {

                return base.ToString() + "\nlocation of the animal:" + location + "\npopulation: " + averageNumrAnim + "\nanimal species: " + survivalSuccess();

            }
        }
    }
