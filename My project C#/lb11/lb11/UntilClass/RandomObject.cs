using lb11.Myinterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb11.UntilClass
{
    public class RandomObject
    {
        public static readonly Random _random = new Random();
        public static ICatalogItem GetRandomObject() {
        int robj=_random.Next(0,3);
            switch (robj)
            {
                case 0:return CreateRandomAlmanac.GetRandomAlmanac(); break;
                case 1:return CreateRandomBooks.GetRandomBook(); break;
                case 2:return CreateRandomNewPaper.GetRandomNewpaper(); break;
                default: return CreateRandomBooks.GetRandomBook();
            }
        }
        //Принцип єдиної відповідальності(Single Responsibility Principle – SRP).
        //Клас повинен мати лише одну причину для зміни.Це означає, що клас повинен виконувати лише одну конкретну функцію або завдання.
    }
}
