using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb10.MethodDelegate
{
   
    public  class  ServiceDate
    {
        public static void MethodTimeNow() => Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        public static void MethodDateNow() => Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd"));
        public static void MethodDayOfWeek() => Console.WriteLine(DateTime.Now.DayOfWeek);
    }
}
