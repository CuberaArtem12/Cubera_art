using lb7_2.My_enum;
using lb7_2.my_exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb7_2.Model
{
    public abstract class Animal
    {
        protected string name;
        protected int age;
        protected string type;
        protected TypeFoodSource typeFoodSource;
        protected float kg;
        protected int amountFoodMonth;
        protected int numberLivingTogether;
        protected Animal() {
            name = "NoName";
            age = 0;
            type = "unspecified";
            typeFoodSource = TypeFoodSource.Omnivores;
            amountFoodMonth = 0;
            kg = 0.0f;
            numberLivingTogether= 0;
        }
        protected Animal(string _name, int _age, string _type, float _kg, TypeFoodSource _typeFoodSource, int _amountFoodMonth, int _numberLivingTogether) { 
        name= _name;   
            age= _age;
            type = _type;
            typeFoodSource= _typeFoodSource;
            amountFoodMonth= _amountFoodMonth;
            kg= _kg;
            numberLivingTogether= _numberLivingTogether;
        }
        public string Name { 
        get { return name; }
            set { if (value == string.Empty) throw new SetDBirthdException("no null");
                        name = value;
            }
        }
        public int Age {
            get { return age; }
            set{if(value <0) throw new SetDBirthdException("no less than zero");
                age = value; 
            }
        } 
        public string Type { 
        get { return type; }
            set { if (value == string.Empty) throw new SetDBirthdException("no null");
                type = value;
            }
        }
        public TypeFoodSource TypefoodSource { 
        get { return typeFoodSource; }
            set { typeFoodSource = value; }
        }
        public int AmountFoodMonth { 
        get { return amountFoodMonth; }
            set {
                if (value < 0) throw new SetDBirthdException("no less than zero");
                amountFoodMonth = value; }
        }
        public float Kg { 
        get { return kg; }
            set {if(value<0) throw new SetDBirthdException("no less than zero");
                kg = value; }
        }
        public int NumberLivingTogether { 
        get { return numberLivingTogether; }
            set
            {
                if (value < 0) throw new SetDBirthdException("no less than zero");
                numberLivingTogether = value;
            }
        }
        public abstract string MakeSound();
        public override string ToString()
        {
            return "Name: "+name+" Age: "+age+" Type: "+ type + " weight: "+kg+ " food source: "+ typeFoodSource+ "\namount of food expenses per month: "+ amountFoodMonth
                + "\nthe number of animals it can tolerate: " + numberLivingTogether;
        }
        public override bool Equals(object obj) {
            Animal other = (Animal)obj;
            return age == other.age && type == other.type&&kg==other.kg;
        }
        public override int GetHashCode() {
            return (name, age, type).GetHashCode();
        }
    }
}
