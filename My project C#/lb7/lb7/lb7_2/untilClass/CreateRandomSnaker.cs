using lb7_2.Model;
using lb7_2.My_enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb7_2.untilClass
{
    internal class CreateRandomSnaker
    {
        public static readonly Random _random = new Random();
        private static string[] Names = { "Sly", "Slither", "Monty", "Jasper", "Severus", "Nagini", "Ziss", "Kaa" };
        private static string[] Types = { "Pythons", "Boas", "Vipers", "Cobras", "Colubrids", "Sea snakes", "Blind snakes", "Adders" };

        public static string GetName()
        {
            return Names[_random.Next(0, Names.Length)];

        }
        public static string GetTypes()
        {
            return Types[_random.Next(0, Types.Length)];

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
            return _random.Next(10, 30);
        }
        public static int GetamountFoodMonth()
        {
            return _random.Next(4, 30);
        }
        public static double Getlenght()
        {
            return _random.Next(10, 20);
        }
       
        public static Snaker CreateSpiderRandom()
        {
            return new Snaker()
            {
                Name = GetName(),
                Age = GetAge(),
                Type = GetTypes(),
                Kg = GetKg(),
                TypefoodSource = GettypeFoodSource(),
                AmountFoodMonth = GetamountFoodMonth(),
                Lenght = Getlenght()

            };
        }
    }
}
