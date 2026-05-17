using lb8_3.myinterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8_3.service
{
    public class EncipherDecryption
    {
        public static void Encipher(object[] massText) {
            foreach (object obj in massText) {
                if (obj is ICipher cipher) {
                    cipher.Text = cipher.Encode(cipher.Text);
                }
            }
        }
        public static void Decipher(object[] massText)
        {
            foreach (object obj in massText)
            {
                if (obj is ICipher cipher)
                {
                    cipher.Text= cipher.Decode(cipher.Text);
                }
            }
        }
    }
}
