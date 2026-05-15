using lb8.Model;
using lb8.My_enum;
using lb8.UntilClass;

namespace lb8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person master = new Person("Artem", "Cubera", new DateTime(2008, 7, 4));
            Device[] devicesList = new Device[] { };
            Computer computer = new Computer(master,TypeOfWork.Home,"8888", devicesList);
            Device device1 = CreateRandomDevice.CrateRandomDevice();
            Device device2 = CreateRandomDevice.CrateRandomDevice();
            Device device3 = CreateRandomDevice.CrateRandomDevice();
            computer.Add(device1);
            computer.Add(device2);
            computer.Add(device3);
            foreach (Device device in computer)
            {
                if (device != null)
                {
                    Console.WriteLine($"Name: {device.Name},Price:{device.Price}");
                }
            }
            Console.ReadKey();
            Console.WriteLine("to sort: ");
            foreach (Device device in computer)
            {
                if (device != null)
                {
                    Console.WriteLine($"Name: {device.Name},Price:{device.Price}");
                }
            }
            computer.Sort();
            Console.WriteLine("after sorting");
            foreach (Device device in computer)
            {
                if (device != null)
                {
                    Console.WriteLine($"Name: {device.Name},Price:{device.Price}");
                }
            }
            Console.ReadKey();
            Device device4 = CreateRandomDevice.CrateRandomDevice();
            computer.Add(device4);
            computer.Save("Save1.txt");
            Console.ReadKey();
            Device[] devicesminiList = new Device[2];
           
            for (int i = 0; i < devicesminiList.Length; i++)
            {
                if (computer[i] != null)
                {

                    Device original = computer[i] as Device;
                    if (original != null)
                    {
                        devicesminiList[i] = (Device)original.Clone();
                    }
                }

            }
            
            Person master2 = new Person("Lilit", "Hrang", new DateTime(2006, 5, 11));
            Computer Minicomputer = new Computer(master, TypeOfWork.Home, "8098", devicesminiList);
            Console.WriteLine("Show Devices Mini List");
            foreach (Device device in devicesminiList)
            {
               if (device != null)
                {
                    Console.WriteLine($"Name: {device.Name},Price:{device.Price}");
                }
            }
            Minicomputer.Save("SaveminilistDevices.txt");
        }
    }
}
