using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lb10_3.Methods
{
    public class MethodsForMass
    {
        public static Predicate<int> Check1= x => x % 7 == 0 && x != 0;
        public static Predicate<int> Check2 = x => x > 0;
        public static Func<int[], Predicate<int>, int> AnalitCountInMass = (mass,analit) =>
        {
            int count = 0;
            foreach (var element in mass)
            {
                if (analit(element))
                {
                    count++;
                }
            }
            return count;
        };
    }
}
