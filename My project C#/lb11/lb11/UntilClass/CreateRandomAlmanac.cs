using lb11.Model.Edition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb11.UntilClass
{
    public class CreateRandomAlmanac
    {
        public static readonly Random _random = new Random();
        private static string[] Authors = { "Artem Lord", "Gleb the Wise", "Speedrunner Zhenya", "Odin", "Bicycle", "Ayanokodzi Kiyotaka" };
        private static string[] Titles = { "The Echoing Anthology", "The Infinite Ledger", "Chronicles of Time", "The Hidden Volume", "The Eternal Archive", "Nexus Almanac" };
        public static string GetAuthors()
        {
            return Authors[_random.Next(0, Authors.Length)];
        }
        public static string GetTitles()
        {
            return Titles[_random.Next(0, Titles.Length)];
        }
        public static DateTime GetReleaseDate()
        {
            int year = _random.Next(2018, 2027);
            int month = _random.Next(1, 13);
            int maxDays = DateTime.DaysInMonth(year, month);
            int day = _random.Next(1, maxDays + 1);
            return new DateTime(year, month, day);
        }
        public static Book[] GetBookList() {
            int a = _random.Next(1, Almanac.maximumNumber+1);
            Book[] res = new Book[a];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] =CreateRandomBooks.GetRandomBook();
            }

            return res;
        }
        public static Almanac GetRandomAlmanac()
        {
            return new Almanac()
            {
                Author = GetAuthors(),
                Title = GetTitles(),
                ReleaseDate = GetReleaseDate(),
                BooksList = GetBookList()
            };
        }
    }
}
