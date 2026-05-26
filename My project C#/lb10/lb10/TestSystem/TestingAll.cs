using lb10.MethodDelegate;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb10.TestSystem
{
    public static class TestingAll
    {
        public static Random rnd = new Random();
        public static void RunTests() {
            ServiceDate serviceisTime = new ServiceDate();
            ServiceNumber serviceNumber = new ServiceNumber();
            ServiceGeometry serviceGeometry = new ServiceGeometry();
            Console.WriteLine("Date info");
            serviceisTime.MethodDateNow();
            serviceisTime.MethodTimeNow();
            serviceisTime.MethodDayOfWeek();
            Console.ReadKey();
            Console.WriteLine("Prime and Finobachi number");
            int a = rnd.Next(0,100);
            Console.WriteLine($"Number: {a}");
            Console.WriteLine($"Is this a prime number? {serviceNumber.PrimeNumber(a)}");
            Console.WriteLine($"Is this a Fibonacci number? {serviceNumber.ifNumberFinobachi(a)}");
            Console.ReadKey();
            Console.WriteLine("Geometry Methods: ");
            double x = 10.5;
            double y = 5.4;
            Console.WriteLine($"Triangle area ({x}; {y}): {serviceGeometry.TriangleArea(x, y)}");
            Console.WriteLine($"Rectangle area ({x}; {y}): {serviceGeometry.RectangleArea(x, y)}");
            Console.ReadKey();
        }
    }
       
}
