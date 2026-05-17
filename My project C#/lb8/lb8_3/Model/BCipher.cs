using lb8_3.myinterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8_3.Model
{
    public class BCipher : ICipher, IComparable<BCipher>
    {
        public string Text { get; set; }
        public BCipher(string initialText)
        {
            Text = initialText;
        }
        public string Encode(string Text) {
            StringBuilder encryptedStr = new StringBuilder(Text);
            char c;
            for (int i = 0; i < encryptedStr.Length; i++)
            {
                c = encryptedStr[i];

                if (char.IsLetter(c))
                {
                    char symbol = char.IsUpper(c) ? 'Z' : 'z';
                    char symbol2 = char.IsUpper(c) ? 'A' : 'a';
                    int indexsymbol = c - symbol2;
                    encryptedStr[i] = (char)(symbol - indexsymbol);
                }
                
            }
            return this.Text = encryptedStr.ToString();
        }
        public string Decode(string Text)
        {
            StringBuilder DecryptedStr = new StringBuilder(Text);
            char c;
            for (int i = 0; i < DecryptedStr.Length; i++)
            {
                c = DecryptedStr[i];

                if (char.IsLetter(c))
                {
                    char symbol = char.IsUpper(c) ? 'Z' : 'z';
                    char symbol2 = char.IsUpper(c) ? 'A' : 'a';
                    int indexsymbol = c - symbol2;
                    DecryptedStr[i] = (char)(symbol - indexsymbol);
                }

            }
            return this.Text = DecryptedStr.ToString();
        }
        public override string ToString()
        {
            return"Words: "+ Text;
        }
        public int CompareTo(BCipher other)
        {
            if (other == null) return 1;
            return string.Compare(this.Text, other.Text);

        }
    }
}
