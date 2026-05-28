using lb11.Model.Edition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb11.UntilClass
{
    public class CreateRandomNewPaper
    {
        public static readonly Random _random = new Random();
        private static string[] Authors = { "Newpaper Dead Company", "Gleb company", "The Daily Bugle.", "OdinDayTime",};
        private static string[] Titles = { "The Daily News", "The Chronicle", "The Gazette", "The Times" };
        private static string[] RMainHeadlines = { "Breaking News", "Interview with Zhenya: How to Beat Minecraft in One Second", "bombing artem and hlib", "Zhenya's Guide to Building 'Optimized' Code", "Politics", "Business & Finance", "Technology", "Science", "Sports", "Entertainment" };
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
            int year = _random.Next(2000, DateTime.Now.Year);
            int month = _random.Next(1, 13);
            int maxDays = DateTime.DaysInMonth(year, month);
            int day = _random.Next(1, maxDays + 1);
            return new DateTime(year, month, day);
        }
        public static string[] GetGenRes()
        {
            int a = _random.Next(1, 7);
            string[] res = new string[a];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = RMainHeadlines[_random.Next(0, RMainHeadlines.Length)];
            }
            return res;
        }
        public static Newspaper GetRandomNewpaper()
        {
            return new Newspaper()
            {
                Author = GetAuthors(),
                Title = GetTitles(),
                ReleaseDate = GetReleaseDate(),
                MainHeadlines = GetGenRes(),
            };
        }
    }
}
