using lb11.Model;
using lb11.Myinterface;
using lb11.Service.LibraryManeger;
using lb11.Service.ServicePrintFolger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb11.TestSystem
{
    public class TestOne
    {
        public static void Test() {
            int maxcount = 20;
            Library myLibrary = new Library("Zhenya's Library", new ICatalogItem[20]);
            for (int i = 0; i < 20; i++)
            {
                LybraryAdd.AddRandom(myLibrary);
            }
            ServicePrint.Print(myLibrary);
            SearchByAuthor searchService = new SearchByAuthor();
            Console.WriteLine("Input Search Author ");
            string f = Console.ReadLine();
            var resultSserchAuthor = searchService.ServiceSearchByAuthor(f,myLibrary);
            Console.WriteLine(  ServicePrintMass.PrintVerticalMass(resultSserchAuthor));
            Console.WriteLine("Input Search Title ");
            f = Console.ReadLine();
            var resultsSerchTitle = SerchByTitleBookAndNewpaper.ServiceSearchByTitle(f,myLibrary.CatalogItems);
            Console.WriteLine(ServicePrintMass.PrintVerticalMass(resultsSerchTitle));
        } 
    }
}
