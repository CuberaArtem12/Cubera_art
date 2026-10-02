using lb2_2kurs2.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lb2_2kurs2.Model
{
    public record Phone(string model, PhoneManufacturer phoneManufacturer,decimal price,DateOnly releaseDate);
}
