using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb10_3.Methods
{
    public class DateMethods
    {
        public static Predicate<DateTime> CheckDateDayProgrammer = (date) => date.DayOfYear == 256;
        
        
    }
}
