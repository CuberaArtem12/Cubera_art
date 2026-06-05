using lb11.Myinterface;
using lb11.Service.ServicePrintFolger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb11.Model.Edition
{
    public class Almanac : ICatalogItem,IColection
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Author { get; set; }
        public static int maximumNumber = 10;
        public Book[] Collection { get; set; } = new Book[maximumNumber];
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
            this.Collection = BooksList;
        }
        public override string ToString()
        {
          return "Almanac Title: " + Title + " Release Date: " + ReleaseDate + " Author " + Author +  " \n====Books:====\n " + ServicePrintMass.PrintVerticalMass(Collection) +"\nEnd Almanac\n"; 
        }
        //Принцип єдиної відповідальності(Single Responsibility Principle – SRP).
        //Клас повинен мати лише одну причину для зміни.Це означає, що клас повинен виконувати лише одну конкретну функцію або завдання.
    }
}
