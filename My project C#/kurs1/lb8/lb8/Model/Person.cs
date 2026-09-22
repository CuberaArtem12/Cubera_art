using lb8.my_exception;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lb8.Model
{
    public class Person : IComparable, ICloneable
    {

        private string name;
        private string lastname;
        private System.DateTime dateofbirth;

        public Person(string _name, string lastname, DateTime _dateofbirth) {
            name = _name;
            this.lastname = lastname;
            dateofbirth = _dateofbirth;
        }
        public Person() {
            name = "Unknown";
            lastname = "Unknown";
            dateofbirth = DateTime.Now;
        }
        public string Name {
            get { return name; }
            set { if (value != string.Empty) name = value;
                else throw new ArgumentOutOfRangeException("no nullD");
            }
        }
        public string Lastname {
            get { return lastname; }
            set
            {
                if (value != string.Empty) lastname = value;
                else throw new ArgumentOutOfRangeException();
            }
        }
        public DateTime Dateofbirth {
            get { return dateofbirth; }
            set { if (value <= DateTime.Now) dateofbirth = value;
                else throw new ArgumentOutOfRangeException();
            }
        }
        public int DateofbirthYear {
            get { return dateofbirth.Year; }
            set {if(value>0&&value<=DateTime.Now.Year) dateofbirth = new DateTime(value, dateofbirth.Month, dateofbirth.Day);
                else throw new ArgumentOutOfRangeException();
            }
        }
        public int Age() {
            int age = DateTime.Now.Year - dateofbirth.Year;
            if (dateofbirth.Month >= DateTime.Now.Month && dateofbirth.Day < DateTime.Now.Day) {
                age --;
            }
            return age;
        }
        public override string ToString()
        {
            return "Name: " + name + " " + lastname +"\nAge:" + Age() + "\ndate of birth: " + dateofbirth.ToShortDateString();
        }
        public string ToShortString() {
            return "Name: " + name + "" + lastname;
        }
        public int CompareTo(object obj)
        {
           if (obj == null) return 1;
           Person OtherDateofbirth = obj as Person;
            if (OtherDateofbirth != null) 
                return this.Dateofbirth.CompareTo(OtherDateofbirth.Dateofbirth);
            else
                throw new SetDMydException("Object is not a.Date of birth");
        }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
