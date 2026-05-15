using lb8.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lb8.UntilClass
{
    internal class CreateRandomDevice
    {
        public static readonly Random _random = new Random();
        private static string[] Names = new string[] { "Mouse", "Keyboard", "Monitor", "Speakers", "Projector", "Webcam ", "Microphone"};
        public static string GetName() {
            return Names[_random.Next(0, Names.Length)];
        }
        public static double GetPrice() { 
        return _random.Next(300, 2000);
        }
        public static DateTime GetDateRelease() {
            int year = _random.Next(2015, 2026);
            int month = _random.Next(1, 13);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int day = _random.Next(1, daysInMonth + 1);
            return new DateTime(year, month, day);
        }
        public static Device CrateRandomDevice() {
            return new Device
            {
                Name = GetName(),
                Price = GetPrice(),
                DataRelease = GetDateRelease(),
            };
        }
    }
}
