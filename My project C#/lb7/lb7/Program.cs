using lb7.Model;

namespace lb7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WildAnimal[] animal = new WildAnimal[] {
            new Predator_Animal("lion",12,"feline","Africa",100,1.5f)
            };
            foreach (WildAnimal animalItem in animal)
            {
                Console.WriteLine($"Animal: {animalItem.ToString()}");
            }
        }
        //9. Створити базовий клас «ДикаТварина» з полями, що описують назву тварини, вікові характеристики і т.д.Створити породжений клас «Хижа тварина» з додатковими полями:
        //місце розташування, середня кількість тварин цього виду, коефіцієнт зміни популяції тварин.
        //Визначити методи, що дозволяють виконати заміну деяких полів класів, метод, який визначає успішність популяції тварин (умови визначити самостійно). 
    }
}
