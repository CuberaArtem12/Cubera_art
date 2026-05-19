using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb9_2.MyStruct
{
    struct CMYK
    {
        private double Black;
        private double Cyan;
        private double Yellow;
        private double Magenta;

        public double[] RgbToCmyk(RGB rgb) {
            double r= rgb.Red/255;
            double g= rgb.Green/255;
            double b= rgb.Blue/255;
            double max = (r > g) ? ((r > b) ? r : b) : ((g > b) ? g : b);
            double Black = 1 - max;
            if (Black == 1)
            {
                Cyan = 0;
                Yellow = 0;
                Magenta = 0;
            }
            else {
                Cyan = (1 - r - Black) / (1 - Black);
                Yellow = (1 - b - Black) / (1 - Black);
                Magenta = (1 - g - Black) / (1 - Black);

            }
            return new double[] { Cyan, Magenta, Yellow, Black };

        }
    }
}
