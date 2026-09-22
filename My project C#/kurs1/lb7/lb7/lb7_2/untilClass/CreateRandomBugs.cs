using lb7_2.Model;
using lb7_2.My_enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb7_2.untilClass
{
    public class CreateRandomBugs
    {
        public static readonly Random _random = new Random();
        private static string[] Names = { "Zhenya", "Lord", "Bugsy", "Barnaby", "Buster", "Benny", "Bertie", "Boris", "Bruno", "Baxter" };
        private static string Types =  "Bugs" ;

        public static string GetName()
        {
            return Names[_random.Next(0, Names.Length)];

        }
       
        public static int GetAge()
        {
            return _random.Next(0, 20);
        }
        public static TypeFoodSource GettypeFoodSource()
        {
            var value = Enum.GetValues(typeof(TypeFoodSource));
            return (TypeFoodSource)value.GetValue(_random.Next(value.Length));
        }
        public static float GetKg()
        {
            return _random.Next(1, 10);
        }
        public static int GetamountFoodMonth()
        {
            return _random.Next(3, 30);
        }
        public static int GetnumberLivingTogether()
        {
            return _random.Next(0, 40);
        }
        public static bool GethasWings()
        { 
        return (_random.Next(1, 3) ==2) ? true : false;
        }
        public static Bugs CreateBugsRandom()
        {
            return new Bugs()
            {
                Name = GetName(),
                Age = GetAge(),
                Type = Types,
                Kg = GetKg(),
                TypefoodSource = GettypeFoodSource(),
                AmountFoodMonth = GetamountFoodMonth(),
                NumberLivingTogether = GetnumberLivingTogether(),
                hasWings = GethasWings()
            };
        }
    }
}
