using lb11.Model;
using lb11.Model.Edition;
using lb11.Myinterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb11.Service.LibraryManeger
{
    public class SerchByTitleBookAndNewpaper
    {
        public static ICatalogItem[] ServiceSearchByTitle(string serchTitle,ICatalogItem[] colection)
        {
            if (colection == null) return new ICatalogItem[0];
            int count = 0;
            foreach (var item in colection)
            {
                    if (CheckingPresenceSomething.CheckTitleinBookandnepaper(serchTitle, item))
                    {
                        count++;
                    }
            }

            ICatalogItem[] results = new ICatalogItem[count];
            int index = 0;
            foreach (var item in colection)
            {
               
                    if (CheckingPresenceSomething.CheckTitleinBookandnepaper(serchTitle, item))
                    {
                        results[index] = item;
                        index++;
                    }
                

            }
            return results;
        }
        //Принцип єдиної відповідальності(Single Responsibility Principle – SRP).
        //Клас повинен мати лише одну причину для зміни.Це означає, що клас повинен виконувати лише одну конкретну функцію або завдання.

        //Принцип відкритості/закритості(Open/Closed Principle – OCP).
        //Програмні сутності(класи, модулі, функції) повинні бути відкритими для розширення, але закритими для модифікацій.Це означає, 
        //що новий функціонал додається через створення нових класів чи модулів, а не шляхом модифікації існуючих.

    }
}
