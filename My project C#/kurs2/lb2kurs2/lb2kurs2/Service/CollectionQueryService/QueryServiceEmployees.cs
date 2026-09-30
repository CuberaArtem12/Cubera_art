using lb2kurs2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2kurs2.Service.CollectionQueryService
{
    internal class QueryServiceEmployees
    {
        public static List<Firm> QueryFirmsWithOver100Employees(List<Firm> mylist)
        {
            var firmsWithOver100Employees = mylist
                .Where(s => s.numberEmployees > 100)
                .Select(s => s).ToList();
            return firmsWithOver100Employees;
        }
        public static List<Firm> QueryFirms100To300Employees(List<Firm> mylist)
        {
            var firms100To300Employees = mylist
                    .Where(s => s.numberEmployees >= 100 && s.numberEmployees <= 300)
                    .Select(s => s).ToList();
            return firms100To300Employees;
        }
    }
}
