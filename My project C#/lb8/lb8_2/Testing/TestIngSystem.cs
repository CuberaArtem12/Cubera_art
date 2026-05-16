using lb8_2.Model;
using lb8_2.myUntilClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lb8_2.Testing
{
    public class TestIngSystem
    {
        public void TestingSystem() {
            Register myRegister = new Register();
            Device[] deviceList = new Device[] {
            CreateRandomAircraft.CreateAircraftRAndoms(),
            CreateRandomArabicCarpet.CreateArabicCarpet(),
            CreateRandomHangGlider.CreateHangGlider(),
            CreateRandomHelicopter.CreateHelicopterRAndoms(),
            CreateRandomHotAirBalloon.CreateHotAirBalloonRAndoms(),
            CreateRandomAircraft.CreateAircraftRAndoms(),
            CreateRandomArabicCarpet.CreateArabicCarpet(),
            CreateRandomHangGlider.CreateHangGlider(),
            CreateRandomHelicopter.CreateHelicopterRAndoms(),
            CreateRandomHotAirBalloon.CreateHotAirBalloonRAndoms()

        };
            myRegister.devices = deviceList;
            Console.WriteLine("All Device");
            myRegister.ShowAllDevices();
            Console.WriteLine("\n======Electronic Divice======");
            myRegister.ShowElectricDevices();
            Console.WriteLine("\n=====Nonting Engine Device=====");
            myRegister.ShowNotingEngineDevices();
            Console.ReadKey();
            Console.WriteLine("\n=====Sort All Device=====");
            Array.Sort(myRegister.devices);
            myRegister.ShowAllDevices();
        }
    }
}
