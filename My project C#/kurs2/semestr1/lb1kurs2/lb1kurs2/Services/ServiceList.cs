using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb1kurs2_1.Services
{
    public class ServiceList<T>
    {     private List<T> mylist { get; set; } = new List<T>();
        public ServiceList() { }
        public ServiceList(List<T> mylist){
            this.mylist=mylist;
            }
        public void AddItem(T objects) {
            if (objects == null) {
                Console.WriteLine("The object does not exist.");
                return;
            }
            mylist.Add(objects);
        }
        public void AddList( T[] item) {
            if (item == null)
            {
                Console.WriteLine("The objectі does not exist.");
                return;
            }
            mylist.AddRange(item);
        }
        public  bool Delete(int index)
        {
           
            mylist.RemoveAt(index);
            return true;
        }
    }
}
