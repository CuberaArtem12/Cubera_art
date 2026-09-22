using lb11.Model.Edition;
using lb11.Myinterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb11.UntilClass
{
    public class CreateRandomAlmanac:IGetItem
    {
        public static readonly Random _random = new Random();
        private readonly IGetItem _bookRandom;
        private static string[] Authors = { "Artem Lord", "Gleb the Wise", "Speedrunner Zhenya", "Odin", "Bicycle", "Ayanokodzi Kiyotaka" };
        private static string[] Titles = { "The Echoing Anthology", "The Infinite Ledger", "Chronicles of Time", "The Hidden Volume", "The Eternal Archive", "Nexus Almanac" };
        public CreateRandomAlmanac(IGetItem bookRandom) {
            _bookRandom = bookRandom;
        }
        public string GetAuthors()
        {
            return Authors[_random.Next(0, Authors.Length)];
        }
        public  string GetTitles()
        {
            return Titles[_random.Next(0, Titles.Length)];
        }
        public  DateTime GetReleaseDate()
        {
            int year = _random.Next(2018, 2027);
            int month = _random.Next(1, 13);
            int maxDays = DateTime.DaysInMonth(year, month);
            int day = _random.Next(1, maxDays + 1);
            return new DateTime(year, month, day);
        }
        public Book[] GetBookList() {
            int a = _random.Next(1, Almanac.maximumNumber+1);
            Book[] res = new Book[a];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = (Book)_bookRandom.GetItem();
            }

            return res;
        }
        public ICatalogItem GetItem()
        {
            return new Almanac()
            {
                Author = GetAuthors(),
                Title = GetTitles(),
                ReleaseDate = GetReleaseDate(),
                Collection = GetBookList()
            };
        }
        //Принцип зв’язності(Dependency Inversion Principle – DIP).
        //Залежності повинні спрямовуватися на абстракції, а не на конкретні реалізації.Це дозволяє створювати гнучкі та легко змінювані системи.
    }
}
