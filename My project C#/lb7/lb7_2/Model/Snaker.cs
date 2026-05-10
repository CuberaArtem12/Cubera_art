using lb7_2.My_enum;
using lb7_2.my_exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb7_2.Model
{
    public class Snaker : Animal
    {
        private double lenght;
        private bool isVenomous;
        public Snaker()
        {
            lenght = 0.0;
            isVenomous = false;
        }
        public Snaker(string _name, int _age,  string _type,float _kg, TypeFoodSource _typeFoodSource, int _amountFoodMonth,  int _numberLivingTogether, double _lenght, bool _isVenomous) : base(_name, _age, _type, _kg, _typeFoodSource, _amountFoodMonth, _numberLivingTogether)
        {
            lenght = _lenght;
            isVenomous = _isVenomous;
        }
        public double Lenght
        {
            get { return lenght; }
            set
            {
                if (value < 0) throw new SetDBirthdException("no less than zero");
                lenght = value;
            }
        }
        public bool IsVenomous
        {
            get { return isVenomous; }
            set { isVenomous = value;}
        }
        public override void MakeSound()
        {
            Console.WriteLine("Shh sh sh sh!!");
        }
        public override string ToString() { 
        return "Snake "+base.ToString()+ "\nLenght: "+ lenght+ "\nis it poisonous? "+ IsVenomous;
        }
    }
}
