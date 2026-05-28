using lb11.Model.Edition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb11.UntilClass
{
    public class CreateRandomBooks
    {
        public static readonly Random _random = new Random();
        private static string[] Authors = {"Artem Lord", "Gleb the Wise", "Speedrunner Zhenya","Odin", "Bicycle", "Ayanokodzi Kiyotaka" };
        private static string[] Titles = { "Henry Patern","Oh My God", "art is a wound", "1000 chocolate dishes", "Rocket", "Optimized code", "i'm tired"};
        private static string[] RGenres = { "Fiction", "Non-Fiction", "Fantasy", "Sci-Fi", "Mystery", "Thriller", "Horror", "Romance", "Historical Fiction", "Biography", "Autobiography", "Self-Help", "History", "Poetry", "Drama", "Adventure", "Dystopian", "Crime", "Comedy", "Philosophy" };
        public static string GetAuthors() {
            return Authors[_random.Next(0, Authors.Length)];
        }
        public static string GetTitles()
        {
            return Titles[_random.Next(0, Titles.Length)];
        }
        public static DateTime GetReleaseDate() {
            int year = _random.Next(2000, 2015);
            int month = _random.Next(1, 13);
            int maxDays = DateTime.DaysInMonth(year, month);
            int day = _random.Next(1, maxDays + 1);
            return new DateTime(year, month, day);
        }
        public static string[] GetGenRes() {
            int a = _random.Next(1,7);
            string[]res= new string[a];
            for (int i = 0; i < res.Length; i++) {
                res[i] = RGenres[_random.Next(0, RGenres.Length)];
            }
            return res;
        }
        public static Book GetRandomBook() {
            return new Book()
            {
                Author = GetAuthors(),
                Title = GetTitles(),
                ReleaseDate = GetReleaseDate(),
                Genres = GetGenRes(),
            };
        }
    }
}
