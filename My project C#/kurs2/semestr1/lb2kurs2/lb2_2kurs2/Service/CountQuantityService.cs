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
        private List<Phone> mylist { get; set; } = new List<Phone>();
        public CountQuantityService() { }
        public CountQuantityService(List<Phone> mylist)
        {
            this.mylist = mylist;
        }
        public int CountQuantity() {
            var phoneNumCount = mylist
                   .Select(s=>s);
            return phoneNumCount.Count();
        }
        public  int CountQuantityPriceOver100() {
            var сountQuantityPriceOver100 = mylist
                .Where(s => s.price > 100)
                .Select(s => s);
            return сountQuantityPriceOver100.Count();
        }
        public int CountInPriceRange(){
            var countPhonesInPriceRange = mylist
                    .Where(s => s.price >= 400 && s.price<=700)
                    .Select(s => s);
            return countPhonesInPriceRange.Count();
        }
        public  int CountByManufacturer( PhoneManufacturer manufacturer) {
        var countByManufacturer = mylist
                .Where(s=>s.phoneManufacturer== manufacturer)
                .Select (s => s);
            return countByManufacturer.Count();
        }
    }
}
