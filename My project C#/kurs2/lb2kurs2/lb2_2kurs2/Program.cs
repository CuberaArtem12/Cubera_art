using lb2_2kurs2.Enum;
using lb2_2kurs2.Model;
using lb2_2kurs2.Service;
using System.Collections.Generic;
using System.Numerics;

namespace lb2_2kurs2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Phone> phones = new List<Phone>
            {
                 new Phone("iPhone 13", PhoneManufacturer.Apple, 650.00m, new DateOnly(2021, 9, 24)),
                 new Phone("iPhone 13", PhoneManufacturer.Apple, 600.00m, new DateOnly(2021, 10, 15)),
                 new Phone("iPhone 15 Pro", PhoneManufacturer.Apple, 999.99m, new DateOnly(2023, 9, 22)),
                 new Phone("Galaxy S22", PhoneManufacturer.Samsung, 550.00m, new DateOnly(2022, 2, 25)),
                 new Phone("Galaxy S22", PhoneManufacturer.Samsung, 500.00m, new DateOnly(2022, 5, 10)),
                 new Phone("Galaxy A14", PhoneManufacturer.Samsung, 95.00m, new DateOnly(2023, 1, 12)),
                 new Phone("Pixel 7a", PhoneManufacturer.Google, 450.00m, new DateOnly(2023, 5, 10)),
                 new Phone("Pixel 8 Pro", PhoneManufacturer.Google, 899.00m, new DateOnly(2023, 10, 12)),
                 new Phone("Xperia 1 V", PhoneManufacturer.Sony, 1199.00m, new DateOnly(2023, 7, 28)),
                 new Phone("Xperia 10 IV", PhoneManufacturer.Sony, 380.00m, new DateOnly(2022, 6, 30))
            };
            Console.WriteLine($"Number of phones: {CountQuantityService.CountQuantity(phones)}");
            Console.WriteLine($"number of phones with a price of more than a hundred: {CountQuantityService.CountQuantityPriceOver100(phones)}");
            Console.WriteLine($"the number of phones priced between 400 and 700: {CountQuantityService.CountInPriceRange(phones)}");
            PhoneManufacturer phoneManufacturer = PhoneManufacturer.Apple;
            Console.WriteLine($"the number of phones from a <<{phoneManufacturer}>> manufacturer: {CountQuantityService.CountByManufacturer(phones, phoneManufacturer)}");
            var phoneMinPrice= phones
            .OrderBy(s=>s.price)
            .FirstOrDefault();
            Console.WriteLine($"Phone with min price: {phoneMinPrice}");
            var phoneMaxPrice = phones
                .MaxBy(s => s.price);
            Console.WriteLine($"Phone with max price: {phoneMaxPrice}");
            var oldestPhone = phones
                .MinBy(s => s.releaseDate);
            Console.WriteLine($"The oldest phone: {oldestPhone}");
            var newestPhone = phones
                .MaxBy(s => s.releaseDate);
            Console.WriteLine($"the newest phone: {newestPhone}");
            decimal avgPrice = phones.Average(s => s.price);
            var averagePhonePrice = phones
                .MinBy(s => Math.Abs(s.price - avgPrice));
            Console.WriteLine($"Phone with average price: {averagePhonePrice}");
            var fivecheapestPhone = phones
                .OrderByDescending(s => s.price)
                .Take(5)
                .Select(s=>s).ToList();
            Console.WriteLine("The five cheapest phones: ");
            fivecheapestPhone.ForEach(el => Console.WriteLine(el));
            var fiveMostexpEnsivePhone = phones
                .OrderBy(s => s.price)
                .Take(5)
                .Select(s => s).ToList();
            Console.WriteLine("The five most expensive phones: ");
            fiveMostexpEnsivePhone.ForEach(el => Console.WriteLine(el));
            var threeoldestPhone = phones
                .OrderBy(s => s.releaseDate)
                .Take(3)
                .Select(s=>s).ToList();
            Console.WriteLine("three The oldest phone: ");
            threeoldestPhone.ForEach(el => Console.WriteLine(el));
            var threeNewestPhone = phones
               .OrderByDescending(s => s.releaseDate)
               .Take(3)
               .Select(s=>s).ToList();
            Console.WriteLine($"three the newest phone: {newestPhone}");
            threeNewestPhone.ForEach(el => Console.WriteLine(el));
            Console.WriteLine("number of phones from each manufacturer: ");
            var groupedPhoneManufacturer = phones.GroupBy(s=>s.phoneManufacturer);
            foreach (var manufacturerGroup in groupedPhoneManufacturer) {
                Console.WriteLine($"{manufacturerGroup.Key}-{manufacturerGroup.Count()}");
            }
            Console.WriteLine("number of phones from each model: ");
            var groupedPhoneModel = phones.GroupBy(s => s.model);
            foreach (var modelGroup in groupedPhoneModel)
            {
                Console.WriteLine($"{modelGroup.Key}-{modelGroup.Count()}");
            }
            Console.WriteLine("number of phones from release year model: ");
            var groupedPhoneReleaseYear = phones.GroupBy(s => s.releaseDate.Year);
            foreach (var releaseYearGroup in groupedPhoneReleaseYear)
            {
                Console.WriteLine($"{releaseYearGroup.Key}-{releaseYearGroup.Count()}");
            }
        }
    }
}
