using lb2kurs2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2kurs2.Service.CollectionQueryService
{
    internal class QueryServiceAllinfo
    {
        public static List<Firm> QueryAllinformation(List<Firm> mylist)
        {
            var allInfor = mylist
                           .Select(s => s).ToList();
            return allInfor;
        }
    }
}
