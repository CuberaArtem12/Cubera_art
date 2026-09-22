using lb9_3.Enum1;
using lb9_3.MyStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb9_3.UntilClass
{
    public class CreateRandomItem
    {
        public static readonly Random _random = new Random();
        private static string[] Names = { "Edge of Inevitability", "Herald of Chaos", "Hope Devourer", "Echo of the Void" };
        public static string GetRandomNames()
        {
            return Names[_random.Next(0, Names.Length)];

        }
        public static int GetRandomCost() {
            return _random.Next(0, 30);
        }
        public static Quality GetRandomQuality()
        {
            var value = Enum.GetValues(typeof(Quality));
            return (Quality)value.GetValue(_random.Next(value.Length));
        }
        public static TypeFight GetRandomTypeFight()
        {
            var value = Enum.GetValues(typeof(TypeFight));
            return (TypeFight)value.GetValue(_random.Next(value.Length));
        }
        public static decimal GetRandomPrice()
        {
            double randomDouble = _random.NextDouble() * 30;
            return Math.Round((decimal)randomDouble, 2);
        }
        public static Item CreateRandomitem() {
            return new Item
            {
                Name = GetRandomNames(),
                Cost = GetRandomCost(),
                Price= GetRandomPrice(),
                quality= GetRandomQuality(),
                typefight= GetRandomTypeFight()
            };
        }

    }
}
