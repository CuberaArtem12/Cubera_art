using lb1kurs2_1.Model;
using lb1kurs2_1.Services;
using lb1kurs2_1.Valid;

namespace lb1kurs2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car[] carsmasive = new Car[] {
             new Car("hors",190),
             new Car("Link",200)
            };
            var cars = new List<Car>() { new Car("Toyota", 100) };
            ServiceList<Car> serviceList = new ServiceList<Car>(cars);
            foreach (var car in cars)
            {
                Console.WriteLine($" {car}");
            }
            Console.WriteLine("New List");

            serviceList.AddList(carsmasive);
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{i + 1} {cars[i]}");
            }

            Console.WriteLine("Enter the number you want to delete.");
            int index = int.Parse(Console.ReadLine()) - 1;
            if (ValidService.Validindex(index, cars.Count))
            {
                serviceList.Delete(index);
                for (int i = 0; i < cars.Count; i++)
                {
                    Console.WriteLine("Delite Object");
                    Console.WriteLine($"{i + 1} {cars[i]}");
                }
            }
        }
    }
}
