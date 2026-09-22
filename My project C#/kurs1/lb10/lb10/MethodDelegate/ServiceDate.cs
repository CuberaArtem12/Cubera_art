using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb10.MethodDelegate
{
    public class  ServiceDate
    {
        public Action MethodTimeNow = () => Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        public Action MethodDateNow = () => Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd"));
        public Action MethodDayOfWeek = () => Console.WriteLine(DateTime.Now.DayOfWeek);
    }
}
