using lb8_2.Model.flydevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8_2.myUntilClass
{
    public class CreateRandomHotAirBalloon
    {
        public static readonly Random _random = new Random();
        private static string[] DevNames = { "Cameron Z-105", "Ultramagic M-77", "Kubicek BB20N" };
        private static string[] MAterial = { "Ripstop Nylon", "Polyester Hyperlast","Wicker and Rattan", "Nomex fabric" };
      
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
            return (float)(_random.NextDouble() * (3.0 - 0.2) + 0.2);
        }
        public static HotAirBalloon CreateHotAirBalloonRAndoms()
        {
            return new HotAirBalloon(
                 GetdevNames(),
                 GetWeight(),
                 GetMAterial()
                );
        }
    }
}
