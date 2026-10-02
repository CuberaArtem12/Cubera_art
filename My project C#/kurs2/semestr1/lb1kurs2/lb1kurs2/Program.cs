using lb1kurs2.Enum;
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
            new Car("BMW", "X5", 190, new DateTime(2023, 5, 12), TypeFuel.Diesel),
          new Car("Link & Co", "01", 200, new DateTime(2024, 8, 20), TypeFuel.Hybrid)
            };
            var cars = new List<Car>() { new Car("Lamborghini", "Revuelto", 350, new DateTime(2023, 3, 29), TypeFuel.Hybrid) };
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
