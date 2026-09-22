using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lb8.My_interface
{
    public interface IContainer<T>
    {
        int Count { get; }
        Object this[int index] { get; set; }
        void Add(T element);
        void Delete(T element);

    }
}
