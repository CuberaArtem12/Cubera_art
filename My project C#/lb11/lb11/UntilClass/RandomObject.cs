using lb11.Myinterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace lb11.UntilClass
{
    public class RandomObject:IGetItem
    {
        public static readonly Random _random = new Random();
        public readonly IGetItem _bookRandom;
        public readonly IGetItem _almanacRandom;
        public readonly IGetItem _newpaperRandom;
        public RandomObject(IGetItem bookRandom, IGetItem almanacRandom, IGetItem newpaperRandom) {
            _bookRandom=bookRandom;
            _almanacRandom=almanacRandom;
            _newpaperRandom=newpaperRandom;
        }
        public ICatalogItem GetItem() {
        int robj=_random.Next(0,3);
            switch (robj)
            {
                case 0: return _almanacRandom.GetItem(); break;
                case 1: return _bookRandom.GetItem(); break;
                case 2: return _newpaperRandom.GetItem(); break;
                default: return _bookRandom.GetItem();
            }
        }
        //Принцип єдиної відповідальності(Single Responsibility Principle – SRP).
        //Клас повинен мати лише одну причину для зміни.Це означає, що клас повинен виконувати лише одну конкретну функцію або завдання.
        //Принцип зв’язності(Dependency Inversion Principle – DIP).
        //Залежності повинні спрямовуватися на абстракції, а не на конкретні реалізації.Це дозволяє створювати гнучкі та легко змінювані системи.
    }
}
