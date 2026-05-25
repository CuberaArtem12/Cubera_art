using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb10.MethodDelegate
{
   
    public class ServiceGeometry
    {
        public static double TriangleArea( double b, double h) => 0.5 * b * h;
        public static double RectangleArea( double a, double b) => a * b;

    }
}
