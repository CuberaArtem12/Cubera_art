using lb3_3kurs2.Model;
using lb3_3kurs2.Service;
using lb3_3kurs2.MethodsInput;

using System.Xml;

namespace lb3_3kurs2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath;
            bool end=false;
            List<Song> playList = CreateListSong.createListSong();
            ServiceListSong serviceSongList = new ServiceListSong(playList);
            while (!end)
            {
                Console.WriteLine("1 - Remove a song from playlist by index");
                Console.WriteLine("2 - Add a new song to playlist");
                Console.WriteLine("3 - Edit existing song information");
                Console.WriteLine("4 - Search songs by various characteristics");
                Console.WriteLine("5 - Save the entire playlist to a file");
                Console.WriteLine("6 - Extract and display song lyrics from a saved file");
                Console.WriteLine("0 - Exit program");
                int n = Input.ValidInputInt();
                
                switch (n)
                {
                    case 1:
                        Console.WriteLine("input index for remove song with playlist: ");
                        int index = int.Parse(Console.ReadLine()) - 1;
                        playList.RemoveAt(index);
                        break;
                    case 2:
                        Console.WriteLine("Input name song: ");
                        string nameSong = Console.ReadLine();
                        Console.WriteLine("Input name author: ");
                        string nameAuthor = Console.ReadLine();
                        Console.WriteLine("Input name composer: ");
                        string nameComposer = Console.ReadLine();
                        Console.WriteLine("Input year writing");
                        Console.WriteLine("Input year: ");
                        int year = int.Parse(Console.ReadLine());
                        Console.WriteLine("Text Song: ");
                        string text = Console.ReadLine();
                        Console.WriteLine("input all performers: ");
                        string performers = Console.ReadLine();
                        List<string> listPerformers = performers
                            .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(p => p.Trim())
                            .ToList();
                        Song song = new Song(nameSong, nameAuthor, nameComposer, year, text, listPerformers);
                        playList.Add(song);
                        break;
                    case 3:
                        serviceSongList.EditInfo();
                        break;
                    case 4:
                      var result =  serviceSongList.SerchsearcVariouscharaCteristics();
                        result.ForEach(s => Console.WriteLine($"all songs in the playlist based on the characteristic you selected\n{s}"));
                        break;
                    case 5:
                        Console.WriteLine("Input file  path for save playlist");
                        filePath = InputFilePath.InputfilePath();
                        serviceSongList.SaveColectionInFile(filePath);
                        break;
                    case 6:
                        Console.WriteLine("Input file path for Extracting text from the file where you saved the playlist.");
                        filePath = InputFilePath.InputfilePath();
                        serviceSongList.textExportColectionInFile(filePath);
                        break;
                    case 0:
                        end = true;
                        Console.WriteLine("End work, thank you");
                        break;
                    default:
                        Console.WriteLine("Error: no such command; please try again.");
                        break;

                }
            }

        }
    }
}
