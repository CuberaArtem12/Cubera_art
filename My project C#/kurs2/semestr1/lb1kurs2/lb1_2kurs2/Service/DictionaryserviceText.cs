using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2kurs2_1.Service
{
    public class DictionaryserviceText
    {
        private Dictionary<string,int> MyDictionary { get; set; }=new Dictionary<string, int>();
        public DictionaryserviceText() { }
        public DictionaryserviceText(Dictionary<string, int> MyDictionary) {
        this.MyDictionary = MyDictionary;
        }
        public void GetWordFrequencie(string[] words) {
            foreach (string word in words)
            {
                if (!MyDictionary.ContainsKey(word.ToLower())) MyDictionary[word.ToLower()] = 1;
                else MyDictionary[word.ToLower()] += 1;
            }
        }
    }
}
