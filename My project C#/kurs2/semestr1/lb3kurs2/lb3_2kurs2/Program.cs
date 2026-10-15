using lb3_2kurs2.MethodsInput;
using System.Text;

namespace lb3_2kurs2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path to the text file");
            string filePathText = InputFilePath.InputfilePath();
            Console.WriteLine("Enter the path to the file containing the words to be censored in the text.");
            string filecensorWordsPath = InputFilePath.InputfilePath();
            string text = File.ReadAllText(filePathText);
            Console.WriteLine($"text:\n{text}");
            string[] wordCensor = File.ReadAllText(filecensorWordsPath).Split("\n", StringSplitOptions.TrimEntries);
            StringBuilder censor = new StringBuilder(text);
            foreach (string word in wordCensor) { 
            censor.Replace(word,new string('*',word.Length));
            }
            censor.ToString();
            Console.WriteLine($"censored text: ");
            Console.WriteLine(censor);
        }
    }
}
