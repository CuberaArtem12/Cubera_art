using lb2kurs2.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2kurs2.Model
{
    public record Firm(string name, DateTime dateEstablishment, BusinessProfile businessProfile, string DirectorFullName, int numberEmployees, string address); 
}
