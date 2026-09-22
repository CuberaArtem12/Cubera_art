using lb8_2.Model.flydevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8_2.myUntilClass
{
    public class CreateRandomArabicCarpet
    {
        public static readonly Random _random = new Random();
        private static string[] DevNames = { "The Phoenix Loom", "Starry Night Silk", "Sultan's Pride", "Golden Oasis" };
        private static string[] MAterial = { "Persian Silk", "Enchanted Wool", "Damascus Brocade", "Gold-infused Cotton" };

        public static string GetdevNames()
        {
            return DevNames[_random.Next(0, DevNames.Length)];

        }
        public static string GetMAterial()
        {
            return MAterial[_random.Next(0, MAterial.Length)];

        }

        public static float GetWeight()
        {
            return (float) (_random.NextDouble() * (0.025 - 0.005) + 0.005);
        }
        public static HotAirBalloon CreateArabicCarpet()
        {
            return new HotAirBalloon(
                 GetdevNames(),
                 GetWeight(),
                 GetMAterial()
                );
        }
    }
}
