using lb8_2.MyInteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8_2.Model
{
    public class Register
    {
        public const int maxCost = 10;
     public Device[] devices=new Device[maxCost];
        public void ShowAllDevices() {
            foreach (Device device in devices) {
                if(device!=null)
                  Console.WriteLine(device);
            }
        }
        public void ShowElectricDevices()
        {

            foreach (Device device in devices)
            {
                if (device != null)
                    if (device.IsElectronic)
                        Console.WriteLine(device);

            }
        }
        public void ShowNotingEngineDevices() {
            foreach (Device device in devices)
            {
                if (device != null)
                    if (device is not IEngine)
                        Console.WriteLine(device);

            }

        }
    }
}
