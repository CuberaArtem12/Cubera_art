using lb8_2.Model.flydevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8_2.myUntilClass
{
    public class CreateRandomHelicopter
    {
        public static readonly Random _random = new Random();
        private static string[] DevNames = { "Sikorsky UH-60 Black Hawk", "Boeing AH-64 Apache", "Eurocopter EC135" };
        private static string[] MAterial = { "Kevlar composites", "Titanium alloys", "Aluminum-lithium" };
        private static string[] Model = { "General Electric T700", "Rolls-Royce Allison 250", "Pratt & Whitney PT6T" };
        public static string GetdevNames()
        {
            return DevNames[_random.Next(0, DevNames.Length)];

        }
        public static string GetMAterial()
        {
            return MAterial[_random.Next(0, MAterial.Length)];

        }
        public static string GetModel()
        {
            return Model[_random.Next(0, Model.Length)];

        }
        public static float GetWeight()
        {
            return (float)(_random.NextDouble() * (22.0 - 5.0) + 5.0);
        }
        public static int GetPower()
        {
            return _random.Next(5000, 30000);
        }
        public static Helicopters CreateHelicopterRAndoms()
        {
            return new Helicopters(
                 GetdevNames(),
                 GetWeight(),
                 GetMAterial(),
                 GetPower(),
                 GetModel()
                );
        }
    }
}
