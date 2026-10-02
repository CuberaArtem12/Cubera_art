using lb1kurs2.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lb1kurs2_1.Model
{
    public record Car(string mark,string model, int Maxspeed, DateTime yearManufacture, TypeFuel typeFuel);
}
