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
            Action showFullDate = ServiceDate.MethodDateNow;
            showFullDate += ServiceDate.MethodTimeNow;
            showFullDate += ServiceDate.MethodDayOfWeek;

            Console.WriteLine("Date info");
            showFullDate();
            Console.ReadKey();
            Console.WriteLine("Prime and Finobachi number");
            Predicate<int> IsPrimeNumber = ServiceNumber.PrimeNumber;
            Predicate<int> IsFinobachiNumber= ServiceNumber.ifNumberFinobachi;
            int a = rnd.Next(0,100);
            Console.WriteLine($"Number: {a}");
            Console.WriteLine($"Is this a prime number? {IsPrimeNumber(a)}");
            Console.WriteLine($"Is this a Finobachi number? {IsFinobachiNumber(a)}");
            Console.ReadKey();
            Console.WriteLine("Geometry Methods: ");
            Func<double, double, double> triangleCalc = ServiceGeometry.TriangleArea;
            Func<double, double, double> rectangleCalc = ServiceGeometry.RectangleArea;
            double x = 10.5;
            double y = 5.4;
            Console.WriteLine($"Triangle area ({x}; {y}): {triangleCalc(x, y)}");
            Console.WriteLine($"Rectangle area ({x}; {y}): {rectangleCalc(x, y)}");
            Console.ReadKey();
        }
    }
       
}
