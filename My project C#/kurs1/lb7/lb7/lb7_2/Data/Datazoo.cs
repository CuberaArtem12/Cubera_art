using lb7_2.Model;
using lb7_2.My_enum;
using lb7_2.untilClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb7_2.Data
{
    public class Datazoo
    {
        public static void ZooData(Zoo zoo) {
            Animal[] animals = new Animal[] {
                CreateRandomBugs.CreateBugsRandom(),
                CreateRandomSnaker.CreateSnakerRandom(),
                 CreateSpider.CreateSpiderRandom(),
                  CreateSpider.CreateSpiderRandom(),
                    CreateRandomBugs.CreateBugsRandom(),
                    CreateRandomBugs.CreateBugsRandom(),
                CreateRandomSnaker.CreateSnakerRandom(),
                 CreateSpider.CreateSpiderRandom(),
                  CreateSpider.CreateSpiderRandom(),
                    CreateRandomBugs.CreateBugsRandom()
            };
            zoo.AddAnimalsTerraium(animals);
        }
      
    }
}
