using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb11.Myinterface
{
    public interface ICatalogItem
    {
        string Title { get; set; }
        DateTime ReleaseDate { get; set; }
        string Author { get; set; }

    }
}
