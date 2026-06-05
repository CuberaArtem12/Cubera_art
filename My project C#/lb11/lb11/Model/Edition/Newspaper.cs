using lb11.Myinterface;
using lb11.Service.ServicePrintFolger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb11.Model.Edition
{
    public class Newspaper : ICatalogItem
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Author { get; set; }
        public string[] MainHeadlines { get; set; }
        public Newspaper()
        {
            Title = "unspecified";
            Author = "unspecified";
            ReleaseDate = DateTime.Now;

        }
        public Newspaper(string Title, string Author, DateTime ReleaseDate, string[] MainHeadlines)
        {
            this.Title = Title;
            this.Author = Author;
            this.ReleaseDate = ReleaseDate;
            this.MainHeadlines = MainHeadlines;
        }
        public override string ToString()
        {
            return "Newpaper Title: " + Title + " Release Date: " + ReleaseDate +" Author " + Author + " Genres: " + ServicePrintMass.PrintHorizontalMass(MainHeadlines);
        }
        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
                return false;
            Newspaper other = (Newspaper)obj;
            return Title == other.Title &&
                   Author == other.Author &&
                   ReleaseDate == other.ReleaseDate;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Title, Author, ReleaseDate);
        }
        //Принцип єдиної відповідальності(Single Responsibility Principle – SRP).
        //Клас повинен мати лише одну причину для зміни.Це означає, що клас повинен виконувати лише одну конкретну функцію або завдання.
    }
}
