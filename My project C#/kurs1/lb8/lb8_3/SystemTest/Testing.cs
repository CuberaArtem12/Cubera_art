using lb8_3.Model;
using lb8_3.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8_3.SystemTest
{
    public class Testing
    {
        public static void Test() {
            string[] texts = { "Artem", "JoJo", "Lord", "Fortuna" };

            ACipher[] aArray = new ACipher[texts.Length];
            BCipher[] bArray = new BCipher[texts.Length];
            for (int i = 0; i < texts.Length; i++) {
                aArray[i] = new ACipher(texts[i]);
                bArray[i] = new BCipher(texts[i]);
            }

            Console.WriteLine("Words Array A:");
            ShowString.Print(aArray);
            Console.WriteLine("Words Array B:");
            ShowString.Print(bArray);
            EncipherDecryption.Encipher(aArray);
            EncipherDecryption.Encipher(bArray);
            Console.WriteLine("Encipher Words Array A:");
            ShowString.Print(aArray);
            Console.WriteLine("Encipher Words Array B:");
            ShowString.Print(bArray);
            Console.WriteLine("Encipher Sort Words Array A:");
            Array.Sort(aArray);
            ShowString.Print(aArray);
            Console.WriteLine("Encipher Sort Words Array B:");
            Array.Sort(bArray);
            ShowString.Print(bArray);
            EncipherDecryption.Decipher(aArray);
            EncipherDecryption.Decipher(bArray);
            Console.WriteLine("Decipher Words Array A:");
            ShowString.Print(aArray);
            Console.WriteLine("Decipher Words Array B:");
            ShowString.Print(bArray);


        }
    }
}
