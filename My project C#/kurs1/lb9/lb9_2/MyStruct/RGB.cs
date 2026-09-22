using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb9_2.MyStruct
{
    struct RGB
    {
        public byte Red;
        public byte Green;
        public byte Blue;
       
        public RGB(byte red, byte green, byte blue) { 
            Red= red;
            Green= green;
            Blue= blue;
        }
        public byte[] Rgb => new byte[] { Red, Green, Blue };
        public string ConvertInHex(byte[] Rgb) {
            StringBuilder hex = new StringBuilder((Rgb.Length*2)+1);
            hex.Append("#");
            for (int i = 0; i < Rgb.Length; i++) {
                int whole= Rgb[i]/16;
                int fraction = Rgb[i] % 16;
                Сomparison(whole, hex);
                Сomparison(fraction, hex);
            }
           return hex.ToString();
        } //я зробив повноціний метод томущо хотів подивитися як конвертація працює підкапотом по моєму баченю
        private void Сomparison(int obj, StringBuilder hex) {
            switch (obj)
            {
                case 10:
                    hex.Append("a");
                    break;
                case 11:
                    hex.Append("b");
                    break;
                case 12:
                    hex.Append("c");
                    break;
                case 13:
                    hex.Append("d");
                    break;
                case 14:
                    hex.Append("e");
                    break;
                case 15:
                    hex.Append("f");
                    break;
                case 16:
                    hex.Append("a");
                    break;
                default:
                    hex.Append(obj);
                    break;
            }
        }
        public double[] ConvertToHsl() {
            double r=Red/255.0;
            double g=Green/255.0;
            double b=Blue/255.0;
            double min = (r < g) ? ((r < b) ? r : b) : ((g < b) ? g : b);
            double max = (r > g) ? ((r > b) ? r : b) : ((g > b) ? g : b);
            double delta = max - min;
            double L = (max + min) / 2.0;
            double S;
            double H = 0;
            if (delta == 0)
            {
                H = S = 0;
            }
            else {
                if (L <= 0.5)
                    S = delta / (min + max);
                else
                    S = delta / (2.0 - max - min);

                if (delta == 0)
                    H = 0;
                else if (max == r)
                    H = 60.0 * ((g - b) / delta);
                else if (max == g)
                    H = 60.0 * (((b - r) / delta) + 2.0);
                else if (max == b)
                    H = 60.0 * (((r - g) / delta) + 4.0);
                if (H < 0) { H += 360; }
            }
            return  new double[] { 360, S*100,L*100 };
        }


    }
}
