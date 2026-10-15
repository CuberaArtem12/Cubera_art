using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lb3kurs2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string filePath;
            Console.WriteLine("Enter the path to the text file");
            while (true) {
                filePath = Console.ReadLine();
                if (filePath != null && File.Exists(filePath)) {
                    Console.WriteLine("file found");
                    break;
                }
                Console.WriteLine("File not found; try again.");
            }
            string vowels = "aeiouAEIOU";
            int sentencesCount = 0;
            int uperLettersCount = 0;
            int lowerLettersCount = 0;
            int vowelsCount = 0;
            int consonantsCount = 0;
            int digitsCount = 0;
            try 
            { 
            string text=File.ReadAllText(filePath);
                Console.WriteLine($"Text: {text}");
                foreach (var c in text) {
                    if (c == '.' || c == '!' || c == '?')
                        sentencesCount++;
                    if (char.IsDigit(c)) {
                        digitsCount++;
                    }
                    if (char.IsLetter(c)) {
                        if (char.IsUpper(c))
                            uperLettersCount++;
                        else lowerLettersCount++;

                        if (vowels.Contains(c))
                            vowelsCount++;
                        else
                            consonantsCount++;
                    }
                }
                int count;
                Console.WriteLine("Statistics: ");
                Console.WriteLine($"Number of sentences: {sentencesCount}");
                Console.WriteLine($"Number of uppercase letters: {uperLettersCount}");
                Console.WriteLine($"Number of lowercase letters: {lowerLettersCount}");
                Console.WriteLine($"Number of vowels: {vowelsCount}");
                Console.WriteLine($"Number of consonants: {consonantsCount}");
                Console.WriteLine($"Number of digits: {digitsCount}");
            } 
            catch (Exception ex) 
            { 
                Console.WriteLine($"The file failed to load.{ex}");
            }
        }
    }
}
