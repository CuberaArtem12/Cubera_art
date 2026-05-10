using lb7_2.My_enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb7_2.Model
{
    public class Bugs:Animal
    {
        private bool hasWings { get; set; }
        public Bugs() {
            hasWings = false;
        }
        public Bugs (string _name, int _age, string _type, float _kg, TypeFoodSource _typeFoodSource, int _amountFoodMonth, int _numberLivingTogether, bool _hasWings) : base(_name, _age, _type, _kg, _typeFoodSource, _amountFoodMonth, _numberLivingTogether)
        {
            hasWings = _hasWings;
        }
        public override void MakeSound() {
            Console.WriteLine("beetle sounds");
        }
        public override string ToString()
        {
            return "Bug " + base.ToString() + "\nHas wings: "+ hasWings;
        }
    }
}
