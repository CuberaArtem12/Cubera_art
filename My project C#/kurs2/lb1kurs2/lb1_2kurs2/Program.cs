using lb2kurs2_1.Service;

namespace lb1_2kurs2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FileName = "";
            string text = "";
            bool validFilework;
            bool ExitWork;
            using (StreamReader str = new StreamReader("firstFile.txt"))
            {
                FileName = str.ReadToEnd();
            }
            var nameListFile = new List<string>(FileName.Split("\n", StringSplitOptions.TrimEntries));
            do
            {
                Console.WriteLine("Select the text file you want to work with.");
                for (int i = 0; i < nameListFile.Count; i++)
                {
                    Console.WriteLine($"{i + 1} {nameListFile[i]}");
                }
                Console.WriteLine("Press 0 to exit.");
                ExitWork = true;
                do
                {
                    validFilework = true;
                    int number = int.Parse(Console.ReadLine());
                    switch (number)
                    {
                        case 0:
                            ExitWork = false;
                            break;
                        case 1:
                            using (StreamReader str = new StreamReader(nameListFile[0]))
                            {
                                text = str.ReadToEnd();
                            }
                            break;
                        case 2:
                            using (StreamReader str = new StreamReader(nameListFile[1]))
                            {
                                text = str.ReadToEnd();
                            }
                            break;
                        case 3:
                            using (StreamReader str = new StreamReader(nameListFile[2]))
                            {
                                text = str.ReadToEnd();
                            }
                            break;

                        default:
                            Console.WriteLine("Such a file is not in the job list.");
                            validFilework = false;
                            break;
                    }
                } while (!validFilework);
                if (!ExitWork)
                {
                    Console.WriteLine($"Text: {text}");
                    var dictionary = new Dictionary<string, int>();
                    char[] separation = { ' ', '!', ',', '.', '?', '\n', '"' };
                    DictionaryserviceText dictionaryServiceText = new DictionaryserviceText(dictionary);
                    dictionaryServiceText.GetWordFrequencie(text.Split(separation, StringSplitOptions.RemoveEmptyEntries));
                    Console.WriteLine("words and the number of times they appear in the text");
                    foreach (var word in dictionary)
                    {
                        Console.WriteLine($"{word.Key} : {word.Value}");
                    }
                }
            } while (ExitWork);
            Console.WriteLine("Thank you for using our app. ");
        }
    }
}
