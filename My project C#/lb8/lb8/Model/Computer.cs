using lb8.My_enum;
using lb8.my_exception;
using lb8.My_interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lb8.Model
{
    public class Computer: IFileContainer<Device>, IEnumerable<Device>
    {
        private Person master;
        private TypeOfWork typeofWork;
        private string iPAdress;
        private Device[] devices;
        private bool IsSaved=false;
        public int Count { get {
                if (devices == null) return 0;
                int count = 0;
                foreach (Device device in devices) {
                    if (device != null) 
                        count++; 
                }
                return count;
            } }
        public object this[int index]
        {
            get
            {
                if (index < 0 || index >= devices.Length)
                    throw new IndexOutOfRangeException("Eror!! non-existent index");
                return devices [index];
            }
            set
            {
                if (index < 0 || index >= devices.Length) 
                    throw new IndexOutOfRangeException("Eror! non-existent index");
                devices[index] = (Device)value;
            }
        }
        public Computer() { 
            master = new Person();
            typeofWork= TypeOfWork.Home;
            iPAdress = "123.0.0.2";
            devices = new Device[0];
        }
        public Computer(Person _master,TypeOfWork _typeofWork, string _iPAdress, Device[] _devices) { 
            master = _master;
            typeofWork= _typeofWork;
            iPAdress= _iPAdress;
            devices = _devices;
        }
        public Person Master { 
            get { return master; }
            set {if(value!=null) master = value;
                else throw new ArgumentOutOfRangeException();
            }
        }
        public TypeOfWork TypeofWork
        {
            get { return typeofWork; }
            set { typeofWork = value; }
        }
        public string IPAdress { 
            get { return iPAdress; }
            set { if(value!=string.Empty)iPAdress = value;
                else throw new ArgumentOutOfRangeException();
            }
        }
        public Device[] Devices { 
        get { return devices; }
            set {if(value!=null) devices = value;
                else throw new ArgumentOutOfRangeException();
            }
        }
        public double TotalPrice
        {
            get {
                double price=0;
                for (int i = 0; i < devices.Length; i++) {
                    price += devices[i].Price;
                } 
                return price;
            }
        }
        public bool this[TypeOfWork index] {
            get {
                if (index == typeofWork) return true;
                else return false;
            }
        }
        public void AddDevices (params Device[] newDevices) {
            int lenght=devices.Length + newDevices.Length;
            Device[] updateDevices=new Device[lenght];
            for (int i = 0; i < devices.Length; i++) {
                updateDevices[i] = devices[i];
            }
            for (int j = 0; j < newDevices.Length; j++)
            {
                updateDevices[devices.Length + j] = newDevices[j];
            }
            this.devices = updateDevices;
            
        }
        public string DeviceList() {
            string list="";
            foreach (var device in devices) {
                list += " - " + device + "\n";
            }
            return list;
        }
        public override string ToString() {
            return "Master\n" + master + "\nType Of Work: " + typeofWork + "\nIp: " + iPAdress + "\nDevices:\n" + DeviceList();
                
        }
        public string ToShortString() {
            return "Master\n" + master + "\nType Of Work: " + typeofWork + "\nIp: " + iPAdress +"\nTotal device price: "+ TotalPrice;
        }
        public bool IsDataSaved => IsSaved;
        public void Add(Device element ) {
            if (element == null) return;
            Device[] newDrvices=new Device[devices.Length+1];
            Array.Copy(devices, 0, newDrvices, 0, devices.Length);
            newDrvices[newDrvices.Length-1] = element;
            this.devices=newDrvices;
            IsSaved = false;
        }
        public void Delete(Device element) {
            int elIndexDlete = -1;
            for (int i = 0; i < devices.Length; i++) {
                if (devices[i] == element) {
                    elIndexDlete = i;
                    break;
                }
            }
            if (elIndexDlete == -1) { 
                Console.WriteLine("noting Devices");
                return;
            }
            Device[] DrvicesNooneDevice = new Device[devices.Length - 1];
            Array.Copy(devices, 0, DrvicesNooneDevice, 0, elIndexDlete);
            Array.Copy(devices, elIndexDlete+1, DrvicesNooneDevice, elIndexDlete, devices.Length-elIndexDlete -1);
            this.devices = DrvicesNooneDevice;
            IsSaved = false;
        }
        public void Save(String fileName) {
            using (StreamWriter streamWriter = new StreamWriter(fileName)) {
                foreach (Device element in this.devices) {
                    if (element != null)
                    {
                        streamWriter.WriteLine($"{element.Name}, {element.Price}, {element.DataRelease}");
                    }
                
                }
            
            }
            IsSaved = true;
        }
        public void Load(String fileName) {
            this.devices = new Device[0];
            try
            {
                string line;
                using (StreamReader streamReader = new StreamReader(fileName))
                {
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        string name = parts[0];
                        double price = double.Parse(parts[1]);
                        DateTime DataRelease = DateTime.Parse(parts[2]);
                        Device newDevice = new Device(name, price, DataRelease);
                        this.Add(newDevice);
                    }
                }
                IsSaved = true;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: File does not exist!");
            }
            catch (Exception ex) {
                Console.WriteLine($"an error occurred, the text cannot be read!{ex}");
            
            }
        


        }
        public IEnumerator<Device> GetEnumerator()
        {
            return (devices as IEnumerable<Device>).GetEnumerator();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public void Sort() {
        Array.Sort(devices);
            IsSaved = false;
        }
    }

    
}
