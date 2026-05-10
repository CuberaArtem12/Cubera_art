using lb7_2.My_enum;
using lb7_2.my_exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb7_2.Model
{
    public class Spider:Animal
    {
        private TypeHunting typeHunting;
        
        public Spider() {
            typeHunting = TypeHunting.SpidersWeb;
        }
        public Spider(string _name, int _age, string _type, float _kg, TypeFoodSource _typeFoodSource, int _amountFoodMonth, int _numberLivingTogether, TypeHunting typeHunting) : base(_name, _age, _type, _kg, _typeFoodSource, _amountFoodMonth,  _numberLivingTogether)
        {
            this.typeHunting = typeHunting;
        }
        public TypeHunting Typehunting { 
        get { return typeHunting; } 
            set
            {
                typeHunting = value; 
            }
        }
        public override void MakeSound()
        {
            Console.WriteLine("Click-click!");
        }
        public override string ToString()
        {
            return "Spider "+ base.ToString()+ " \nType Hunting: "+ typeHunting;
        }
    }
}
