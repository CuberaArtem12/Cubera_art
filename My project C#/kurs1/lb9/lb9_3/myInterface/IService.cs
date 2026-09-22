using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb9_3.myInterface
{
    public interface IService<T>
    {
        void Add(T element);
        void Delete(T element);
        bool Update(string nameToFind, T element);
    }
}
