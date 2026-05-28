using lb11.Model;
using lb11.Model.Edition;
using lb11.Myinterface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb11.Service.LibraryManeger
{
    public class SearchByAuthor:IServiceSearchByAuthor<Library>
    {
        public ICatalogItem[] ServiceSearchByAuthor(Library library) {
            if (library == null || library.CatalogItems == null) return new ICatalogItem[0];
            Console.WriteLine("Input Search Author ");
            string f=Console.ReadLine();
            ICatalogItem[] results = new ICatalogItem[RecalculateCount.CurCount(library.CatalogItems)];
            int count = 0;
            foreach (var item in library.CatalogItems) {
                if (item == null) continue;
                bool checkSerch = false;
                if (item.Author.Equals(f, StringComparison.OrdinalIgnoreCase)) {
                    checkSerch=true;
                }
                else if (item is IBooksColection collection) {
                    foreach (var itm in collection.BooksList) {
                        if (itm != null) continue;
                        if (itm.Author.Equals(f, StringComparison.OrdinalIgnoreCase))
                        {
                            checkSerch = true;
                            break;
                        }
                    }
                }
                if (checkSerch) {
                results[count] = item;
                    count++;
                }
            }
            return results;
        }
    }
}
