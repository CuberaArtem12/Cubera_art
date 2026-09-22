using lb7_2.Model;
using lb7_2.My_enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb7_2.untilClass
{
    public class UntilCreateTerrarium
    {
        public static Terrarium CreateTerrariumForBugs()
        {
            return new Terrarium {typeTerrarium = TypeTerrarium.TerrariumBugs,animals= new Animal[Terrarium.maximumcapacity] };
        }

        public static Terrarium CreateTerrariumForSpiders()
        {
            return new Terrarium { typeTerrarium = TypeTerrarium.TerrariumSpider, animals = new Animal[Terrarium.maximumcapacity] };
        }

        public static Terrarium CreateTerrariumForSnakes()
        {
            return new Terrarium{ typeTerrarium = TypeTerrarium.TerrariumSnaker, animals = new Animal[Terrarium.maximumcapacity] };
        }
    }
}
