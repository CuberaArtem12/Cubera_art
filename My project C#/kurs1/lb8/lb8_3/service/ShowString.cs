using lb8_3.myinterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8_3.service
{
    public class ShowString
    {
        public static void Print(object[] massText) {
            foreach (var item in massText) {
                if (item is ICipher cipher)
                {
                    Console.WriteLine(cipher.Text);
                }
            }

        }
    }
}
