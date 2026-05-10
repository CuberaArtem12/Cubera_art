using lb7_2.Model;
using lb7_2.My_enum;

namespace lb7_2
{
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[]
            {
            new Spider ("Peter",8,"kohald",12.5f,TypeFoodSource.Carnivores, 30 , 3,TypeHunting.SpidersWeb),
             new Bugs ("Zhenya",2,"jokal",5.5f,TypeFoodSource.Herbivores, 10 , 100,true)

            };
            Terrarium terrarium = new Terrarium("Smallworld", animals );
            Console.WriteLine(terrarium.ToString());
        }
    }
}
