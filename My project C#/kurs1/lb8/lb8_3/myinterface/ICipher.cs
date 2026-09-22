using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8_3.myinterface
{
    public interface ICipher
    {
        string Encode(string text);
        string Decode(string text);
        string Text { get; set; }
    }
}
