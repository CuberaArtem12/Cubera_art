using lb8_3.myinterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8_3.Model
{
    public class ACipher : ICipher, IComparable<ACipher>
    {
        public string Text { get; set; }
        public ACipher(string initialText)
        {
            Text = initialText;
        }
        public string Encode(string Text)
        {
            char[] encryptedStr = Text.ToCharArray();
            char c;
            for (int i = 0; i < encryptedStr.Length; i++)
            {
                c = encryptedStr[i];

                if (char.IsLetter(c))
                {
                    char symbol = char.IsUpper(c) ? 'A' : 'a';
                    encryptedStr[i] = (char)(((c - symbol + 1) % 26) + (symbol));
                }

            }
            return this.Text= new string(encryptedStr);
        }
        public string Decode(string Text)
        {
            StringBuilder decryptionStr = new StringBuilder(Text);
            char c;
            for (int i = 0; i < decryptionStr.Length; i++)
            {
                c = decryptionStr[i];
                if (char.IsLetter(c))
                {

                    char symbol = char.IsUpper(c) ? 'A' : 'a';
                    decryptionStr[i] = (char)(((c - symbol - 1) % 26) + (symbol));

                }

            }
            return this.Text =decryptionStr.ToString();
        }
        public override string ToString()
        {
            return "Words: " + Text;
        }
        public int CompareTo(ACipher other)
        {
            if (other == null) return 1;
            return string.Compare(this.Text, other.Text);

        }
    }
}
