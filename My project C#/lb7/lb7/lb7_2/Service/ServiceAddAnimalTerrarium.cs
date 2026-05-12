using lb7_2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb7_2.Service
{
    public class ServiceAddAnimalTerrarium
    {
       
        Terrarium terarium { get; set; }
        public  void AddAnimals(Terrarium terarium, params Animal[] Newanimals)
        {
            int freespace=0;
            Animal[] Updateanimals = new Animal[Terrarium.maximumcapacity];
            if (Newanimals == null) { Console.WriteLine("nothing to add"); return; }
            
                if (terarium.AnimalsCount > 0)
                {
                    Array.Copy(terarium.animals, 0, Updateanimals, 0, terarium.AnimalsCount);
                }
            if (terarium.AnimalsCount + Newanimals.Length <= Terrarium.maximumcapacity)
            {
                Array.Copy(Newanimals, 0, Updateanimals, terarium.AnimalsCount, Newanimals.Length);
                terarium.animals = Updateanimals;
                return;
            }
            freespace = Terrarium.maximumcapacity - terarium.AnimalsCount;
            if (freespace > 0)
            {
                Array.Copy(Newanimals, 0, Updateanimals, terarium.AnimalsCount, freespace);
            }
            terarium.animals = Updateanimals;


        }
    }
}
