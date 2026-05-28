using lb11.Model;
using lb11.Myinterface;
using lb11.UntilClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lb11.Service.LibraryManeger
{
    public class LybraryAdd
    {
        public static void AddRandom(Library library) {
            ICatalogItem element = RandomObject.GetRandomObject();
            if (element == null || library == null) return;
            var currentItemsCount = RecalculateCount.CurCount(library.CatalogItems);
            ICatalogItem[] newItems = new ICatalogItem[currentItemsCount + 1];
            Array.Copy(library.CatalogItems, 0, newItems, 0, currentItemsCount);
            newItems[newItems.Length - 1] = element;
            library.CatalogItems = newItems;

        }
    }
}
