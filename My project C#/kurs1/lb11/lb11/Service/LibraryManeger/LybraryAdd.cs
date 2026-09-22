using lb11.Model;
using lb11.Myinterface;
using lb11.UntilClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lb11.Service.LibraryManeger
{
    public class LybraryAdd
    {
        private readonly IGetItem _itemRandom;
        public LybraryAdd(IGetItem itemRandom){
            _itemRandom=itemRandom;
        }
        public void AddRandom(Library library) {
            if (_itemRandom == null) {
                throw new ArgumentNullException($"problem with {_itemRandom}");
            }
            ICatalogItem element = _itemRandom.GetItem();
            if (element == null || library == null) return;
            var currentItemsCount = RecalculateCount.CurCount(library.CatalogItems);
            ICatalogItem[] newItems = new ICatalogItem[currentItemsCount + 1];
            Array.Copy(library.CatalogItems, 0, newItems, 0, currentItemsCount);
            newItems[newItems.Length - 1] = element;
            library.CatalogItems = newItems;

        }
        //Принцип зв’язності(Dependency Inversion Principle – DIP).
        //Залежності повинні спрямовуватися на абстракції, а не на конкретні реалізації.Це дозволяє створювати гнучкі та легко змінювані системи.
        //Принцип єдиної відповідальності(Single Responsibility Principle – SRP).
        //Клас повинен мати лише одну причину для зміни.Це означає, що клас повинен виконувати лише одну конкретну функцію або завдання.
    }
}
