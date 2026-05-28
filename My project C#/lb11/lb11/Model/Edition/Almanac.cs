using lb11.Myinterface;
using lb11.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb11.Model.Edition
{
    public class Almanac : ICatalogItem,IBooksColection
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Author { get; set; }
        public static int maximumNumber = 10;
        public Book[] BooksList { get; set; } = new Book[maximumNumber];
        public Almanac()
        {
            Title = "unspecified";
            Author = "unspecified";
            ReleaseDate = DateTime.Now;
           
        }
        public Almanac(string Title, string Author, DateTime ReleaseDate, Book[] BooksList)
        {
            this.Title = Title;
            this.Author = Author;
            this.ReleaseDate = ReleaseDate;
            this.BooksList = BooksList;
        }
        public override string ToString()
        {
          return "Title: " + Title + " Release Date: " + ReleaseDate + " \n====Books:====\n " + ServicePrintMass.PrintVerticalMass(BooksList); 
        }
    }
}
