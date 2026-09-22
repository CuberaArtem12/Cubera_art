using lb7_2.Model;
using lb7_2.My_enum;
using lb7_2.Data;
using lb7_2.untilClass;

namespace lb7_2
{
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Terrarium[] terrariumList = new Terrarium[]
                {
            new Terrarium(TypeTerrarium.TerrariumBugs, new Animal[Terrarium.maximumcapacity]),
            new Terrarium(TypeTerrarium.TerrariumSnaker, new Animal[Terrarium.maximumcapacity]),
            new Terrarium(TypeTerrarium.TerrariumSpider, new Animal[Terrarium.maximumcapacity])
                };
            Zoo zoo= new Zoo("TarTar", terrariumList);
            Datazoo.ZooData(zoo);
            Console.WriteLine($"welcome to the Zoo {zoo.name}");
            zoo.AddAnimalsTerraium();
            zoo.ShowTerarium();
            Console.WriteLine($"Total {zoo.name} wastes food on motnth: {zoo.TotalFoodInMoth()}");
        }
    }
}
