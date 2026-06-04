using lb11.Model;
using lb11.Model.Edition;
using lb11.Myinterface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb11.Service.LibraryManeger
{
    public class SearchByAuthor:IServiceSearchByAuthor<Library>
    {
        public ICatalogItem[] ServiceSearchByAuthor(string serchAuthor,Library library) {
            if (library == null || library.CatalogItems == null) return new ICatalogItem[0];
            int count = 0;
            foreach (var item in library.CatalogItems) {
                  if (item == null) continue;
                if (CheckingPresenceSomething.CheckAuthor(serchAuthor, item)) { 
                 count++;
                }
            }
                  
            ICatalogItem[] results = new ICatalogItem[count];
            int index = 0;
            foreach (var item in library.CatalogItems) {
                if (CheckingPresenceSomething.CheckAuthor(serchAuthor, item))
                {
                    results[index] = item;
                    index++;
                }

            }
            return results;
        }
        //Принцип відкритості/закритості(Open/Closed Principle – OCP).
        //Програмні сутності(класи, модулі, функції) повинні бути відкритими для розширення, але закритими для модифікацій.Це означає, 
        //що новий функціонал додається через створення нових класів чи модулів, а не шляхом модифікації існуючих.
        //Принцип єдиної відповідальності(Single Responsibility Principle – SRP).
        //Клас повинен мати лише одну причину для зміни.Це означає, що клас повинен виконувати лише одну конкретну функцію або завдання.
    }
}
