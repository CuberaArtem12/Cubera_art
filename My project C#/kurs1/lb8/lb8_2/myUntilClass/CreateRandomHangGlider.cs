using lb8_2.Model.flydevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8_2.myUntilClass
{
    public class CreateRandomHangGlider
    {
        public static readonly Random _random = new Random();
        private static string[] DevNames = { "Wills Wing Alpha", "Moyes Litespeed", "Icaro 2000 Laminar", "Airborne XT 912" };
        private static string[] MAterial = { "Dacron fabric", "Aircraft Aluminum 7075", "Carbon composite spars" };

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
            return (float)(_random.NextDouble() * (0.050 - 0.025) + 0.025);
        }
        public static HangGlider CreateHangGlider()
        {
            return new HangGlider(
                 GetdevNames(),
                 GetWeight(),
                 GetMAterial()
                );
        }
    }
}
