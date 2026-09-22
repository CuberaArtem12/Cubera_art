using lb8_2.Model;
using lb8_2.Model.flydevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lb8_2.myUntilClass
{
    public class CreateRandomAircraft
    {
        public static readonly Random _random = new Random();
        private static string[] DevNames = { "Boeing 737", "Airbus A320", "Boeing 777", "Airbus A350" };
        private static string[] MAterial = { "Aluminum alloys", "Titanium", "Carbon fiber", "Stainless steel", "Composites" };
        private static string[] Model = { "CFM International CFM56", "General Electric GE90", "Rolls-Royce Trent 1000", "Pratt & Whitney PW1000G" };
        public static string GetdevNames() { 
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
        public static float GetWeight() {
            return (float)(_random.NextDouble() * (30.0 - 10.0) + 10.0);
        }
        public static int GetPower() { 
         return _random.Next(10000, 20000);
        }
        public static Aircraft CreateAircraftRAndoms() {
            return new Aircraft(
                 GetdevNames(),
                 GetWeight(),
                 GetMAterial(),
                 GetPower(),
                 GetModel()
                );
        }

    }
}
