using lb11.Myinterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lb11.Service.ServicePrintFolger;

namespace lb11.Model.Edition
{
    public class Book: ICatalogItem, IGenres
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Author { get; set; }
        public string[] Genres { get; set; }
        public Book() {
            Title = "unspecified";
            Author = "unspecified";
            ReleaseDate = DateTime.Now;
        }
        public Book(string Title, string Author, DateTime ReleaseDate, string[] Genres) {
        this.Title = Title;
            this.Author = Author;
            this.ReleaseDate = ReleaseDate;
            this.Genres= Genres;
        }
        public override string ToString()
        {
            return "Book Title: " + Title+ " Release Date: " + ReleaseDate+" Author " + Author + " Genres: "+ServicePrintMass.PrintHorizontalMass(Genres);
        }
        public override bool Equals(object obj)
        {
           
            if (obj == null || GetType() != obj.GetType())
                return false;
            Book other = (Book)obj;
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
