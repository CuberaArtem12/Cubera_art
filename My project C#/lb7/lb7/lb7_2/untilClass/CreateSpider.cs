using lb7_2.Model;
using lb7_2.My_enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb7_2.untilClass
{
   
    internal class CreateSpider
    {
        public static readonly Random _random = new Random();
        private static string[] Names = { "Artem", "Handrid", "Herda","PocoLoco" };
        private static string[] Types = { "Orb-weavers", "Wolf spiders", "Jumping spiders", "Cellar spiders", "Cobweb spiders", "Crab spiders", "Nursery web spiders", "Funnel-web spiders" };

        public static string GetName()
        {
            return Names[_random.Next(0, Names.Length)];

        }
        public static string GetTypes()
        {
            return Types[_random.Next(0, Types.Length)];

        }
        public static int GetAge() {
            return _random.Next(1, 20);
        }
        public static TypeFoodSource GettypeFoodSource() {
            var value = Enum.GetValues(typeof(TypeFoodSource));
        return (TypeFoodSource)value.GetValue (_random.Next(value.Length));
        }
        public static float GetKg() {
            return _random.Next(1, 10);
        }
        public static int GetamountFoodMonth()
        {
            return _random.Next(2, 30);
        }
        public static int GetnumberLivingTogether()
        {
            return _random.Next(0, 4);
        }
        public static TypeHunting GettypeHunting()
        {
            var value = Enum.GetValues(typeof(TypeHunting));
            return (TypeHunting)value.GetValue(_random.Next(value.Length));
        }
        public static Spider CreateSpiderRandom() {
            return new Spider()
            {
                Name = GetName(),
                Age = GetAge(),
                Type = GetTypes(),
                Kg= GetKg(),
                TypefoodSource = GettypeFoodSource(),
                AmountFoodMonth= GetamountFoodMonth(),
                NumberLivingTogether= GetnumberLivingTogether(),
                Typehunting= GettypeHunting()
            };
        }
    }
}
