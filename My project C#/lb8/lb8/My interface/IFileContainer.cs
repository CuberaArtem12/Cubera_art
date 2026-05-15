using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8.My_interface
{
    public interface IFileContainer<T>: IContainer<T>
    {
        void Save(String fileName);
        void Load(String fileName);
        Boolean IsDataSaved { get; }

    }
}
