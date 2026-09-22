using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb11.Myinterface
{
    public interface IServiceSearchByAuthor<T>
    {
        ICatalogItem[] ServiceSearchByAuthor(string serchAuthor, T elementt);
    }
}
