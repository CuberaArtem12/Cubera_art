using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb11.Service
{
    public class ServicePrintMass
    {
        public static string  PrintVerticalMass(object[] itm) {
            StringBuilder list = new StringBuilder();
            foreach (var item in itm)
            {
                if (item != null)
                {
                    list.Append(" - ")
               .Append(item)
               .Append("\n");
                }
            }
            return list.ToString();
        }
        public static string PrintHorizontalMass(object[] itm)
        {
            StringBuilder list = new StringBuilder();
            foreach (var item in itm)
            {
                if (item != null)
                {
                    list.Append(", ")
               .Append(item);
                }
            }
            return list.ToString();
        }
    }
}
