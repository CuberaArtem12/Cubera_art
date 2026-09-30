using lb2kurs2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2kurs2.Service.CollectionQueryService
{
    internal class QueryServiceDate
    {
        public static List<Firm> FirmsFoundedTwoYearsAgo(List<Firm> mylist)
        {
            var firmTwoYearsAgo = mylist
                .Where(s => s.dateEstablishment < DateTime.Now.AddYears(-2))
                .Select(s => s).ToList();
            return firmTwoYearsAgo;
        }
        public static List<Firm> QueryFirmsOlderThan150Days(List<Firm> mylist)
        {
            var firmsOlderThan150Days = mylist
                .Where(s => s.dateEstablishment < DateTime.Now.AddDays(-150))
                .Select(s => s).ToList();
            return firmsOlderThan150Days;

        }
    }
}
