using lb11.Model.Edition;
using lb11.Myinterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb11.Service
{
    public class CheckingPresenceSomething
    {
        public static bool CheckAuthor(string serchAuthor,ICatalogItem item)
        {
           
            bool checkSerch = false;
            if (item.Author.Equals(serchAuthor, StringComparison.OrdinalIgnoreCase))
            {
                checkSerch = true;
            }
            else if (item is IColection collection)
            {
                foreach (var itm in collection.Collection)
                {
                    if (itm == null) continue;
                    if (itm.Author.Equals(serchAuthor, StringComparison.OrdinalIgnoreCase))
                    {
                        checkSerch = true;
                        break;
                    }

                }
            }
            return checkSerch;
        }
        public static bool CheckTitleinBookandnepaper(string serchTitle, ICatalogItem item)
        {

            bool checkSerch = false;
            if (item is Book || item is Newspaper)
            {
                if (item.Title.Equals(serchTitle, StringComparison.OrdinalIgnoreCase))
                {

                    checkSerch = true;

                }
            }
            return checkSerch;
        }
    }
}
