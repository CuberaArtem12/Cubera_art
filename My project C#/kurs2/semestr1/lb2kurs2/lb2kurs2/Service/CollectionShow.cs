using lb2kurs2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2kurs2.Service
{
    internal class CollectionShow
    {
        public static void ShowCollection(List<Firm> list){
            list.ForEach(el=> Console.WriteLine(el));
        }

    }
    
}
