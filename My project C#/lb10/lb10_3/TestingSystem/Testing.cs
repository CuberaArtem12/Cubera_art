using lb10_3.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb10_3.TestingSystem
{
    public class Testing
    {
        public static void Test() { 
         Random rnd = new Random();
            int[] numbers=new int[10];
            Console.WriteLine("Methods for int mass");
            for (int i = 0; i < numbers.Length; i++) { 
            numbers[i] = rnd.Next(-20,100);
            }
            foreach (int i in numbers) {
                Console.Write($"{i} ");
            }
            Console.WriteLine("");
            Console.WriteLine("A method for counting the number of numbers in an array that are multiples of seven;");
           int count= MethodsForMass.AnalitCountInMass(numbers, MethodsForMass.Check1);
            Console.WriteLine("Count: "+count);
            Console.WriteLine("Method for counting the number of positive numbers in an array;");
            count = MethodsForMass.AnalitCountInMass(numbers, MethodsForMass.Check2);
            Console.WriteLine($"Count: {count}");
            Console.ReadKey();
            Console.WriteLine("Methods Date"); 
            DateTime date = DateTime.Now;
            Console.WriteLine($"today's date: {date}");
            Console.WriteLine($"Is today programmer's day? {DateMethods.CheckDateDayProgrammer(date)}");
            Console.ReadKey();
            Console.WriteLine("String Methods");
            string text = "Ara ara sate sate";
            string word = "lol";
            Console.WriteLine($"Text: {text}");
            Console.WriteLine($"Is this word({word}) in the text? {StringMethods.CheckWordInText(text, word)}");
            Console.ReadKey();

        }
    }
}
