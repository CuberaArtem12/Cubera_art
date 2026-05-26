using lb10_2.Models;
using lb10_2.My_enum;
using lb10_2.ServiceMethod;
using lb10_2.ServicePrint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lb10_2.TestingSystem
{
    public class Testing1
    {
        public static void Test() { 
        Suitcase suitcase = new Suitcase("HlibAndTemaCompany",7.0f,40,Colors.Red);
            Item[] items = new Item[] { 
            new Item("LapTop",10,2.0f),
            new Item("Phone",2,0.14f)
            };
            suitcase.OnItemAdding += Handler.Masage;
            for (int i = 0; i < items.Length; i++) {
                suitcase.AddItemInSuitcase(items[i]);
            }
            ServPrint.Print(suitcase);
            Console.ReadKey();
            try {
                suitcase.AddItemInSuitcase(new Item("LapTop", 50, 2.0f));
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
