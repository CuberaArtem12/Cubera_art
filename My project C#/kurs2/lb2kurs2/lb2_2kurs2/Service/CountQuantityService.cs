using lb2_2kurs2.Enum;
using lb2_2kurs2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2_2kurs2.Service
{
    internal class CountQuantityService
    {
        public static int CountQuantity(List<Phone> List) {
            var phoneNumCount = List
                   .Select(s=>s);
            return phoneNumCount.Count();
        }
        public static int CountQuantityPriceOver100(List<Phone> List) {
            var сountQuantityPriceOver100 = List
                .Where(s => s.price > 100)
                .Select(s => s);
            return сountQuantityPriceOver100.Count();
        }
        public static int CountInPriceRange(List<Phone> List){
            var countPhonesInPriceRange = List
                    .Where(s => s.price >= 400 && s.price<=700)
                    .Select(s => s);
            return countPhonesInPriceRange.Count();
        }
        public static int CountByManufacturer(List<Phone> List, PhoneManufacturer manufacturer) {
        var countByManufacturer = List
                .Where(s=>s.phoneManufacturer== manufacturer)
                .Select (s => s);
            return countByManufacturer.Count();
        }
    }
}
