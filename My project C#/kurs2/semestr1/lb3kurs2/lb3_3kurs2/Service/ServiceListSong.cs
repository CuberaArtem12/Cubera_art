using lb3_3kurs2.MethodsInput;
using lb3_3kurs2.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace lb3_3kurs2.Service
{
    internal class ServiceListSong
    {
      private  List<Song> playlist=new List<Song>();
        public ServiceListSong() { }
        public ServiceListSong(List<Song> playlist)
        {
            this.playlist = playlist;
        }
        public void EditInfo() {
            if (playlist.Count == 0)
            {
                Console.WriteLine("Collection is empty!");
                return;
            }
            Console.Write("Enter the title of the song you want to edit: ");
            string titleToEdit = Console.ReadLine();
            Song song = playlist.Find(s => s.NameSong.Equals(titleToEdit, StringComparison.OrdinalIgnoreCase));
            if (song == null)
            {
                Console.WriteLine("Song with this title was not found.");
                return;
            }
            bool editing = true;
            while (editing) {
                Console.WriteLine("1. Change name song");
                Console.WriteLine("2. Change author");
                Console.WriteLine("3. Change composer");
                Console.WriteLine("4. Change song text");
                Console.WriteLine("0. Finish editing this song");
                Console.Write("Select an option: ");
                int d= Input.ValidInputInt();
                switch (d)
                {
                    case 1: 
                        Console.Write($"Input new name song (current: {song.NameSong}): ");
                        string newNameSong=Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(newNameSong)) song.NameSong = newNameSong;
                        break;
                        case 2:
                        Console.Write($"Input author (current: {song.NameAuthor}): ");
                        string newNameAuthor = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(newNameAuthor)) song.NameAuthor = newNameAuthor;
                        break;
                        case 3:
                        Console.Write($"Input author (current: {song.Composer}): ");
                        string newComposer = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(newComposer)) song.Composer = newComposer;
                        break;
                    case 4:
                        Console.Write($"Input author (current: {song.TextSong}): ");
                        string newTextSong = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(newTextSong)) song.TextSong = newTextSong;
                        break;
                        case 0:
                        editing = false;
                        Console.WriteLine("Edit End");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }

            }
        }
        public List<Song> SerchsearcVariouscharaCteristics() {
            List<Song> results = new List<Song>();
            Console.WriteLine("By which characteristic do you want to search?");
            Console.WriteLine("1. Search by  name song");
            Console.WriteLine("2. Search by author");
            Console.WriteLine("3. Search by composer");
            Console.WriteLine("4. Search by year");
            Console.WriteLine("5. Search by performer");
            Console.WriteLine("0. Cancel search");
            int d = Input.ValidInputInt();
            switch (d) {
                case 1:
                    Console.Write("Input name song to search: ");
                    string snameSong = Console.ReadLine();

                    results = playlist
                        .Where(s => s.NameSong.Contains(snameSong, StringComparison.OrdinalIgnoreCase))
                        .ToList();
                    break;
                case 2:
                    Console.Write("Input author to search: ");
                    string snameAuthor = Console.ReadLine();

                    results = playlist
                        .Where(s => s.NameAuthor.Contains(snameAuthor, StringComparison.OrdinalIgnoreCase))
                        .ToList();
                    break;
                case 3:
                    Console.Write("Input  composer  to search: ");
                    string snameComposer = Console.ReadLine();

                    results = playlist
                        .Where(s => s.Composer.Contains(snameComposer, StringComparison.OrdinalIgnoreCase))
                        .ToList();
                    break;
                case 4:
                    Console.Write("Input year to search: ");
                   int syear  =int.Parse(Console.ReadLine());
                    results = playlist
                        .Where(s => s.YearWriting==syear)
                        .ToList();
                    break;
                case 5:
                    Console.Write("Input performer to search: ");
                    string performer = Console.ReadLine();
                    results = playlist
                        .Where(s => s.Performers.Any(p => p.Contains(performer, StringComparison.OrdinalIgnoreCase)))
                        .ToList();
                    break;
                case 0:
                    Console.WriteLine("Search cancelled.");
                    break;

                default:
                    Console.WriteLine("Invalid option selected.");
                    break;
            }
            return results;
        }
        public void SaveColectionInFile(string filePath)
        {
            List<string> lines = new List<string>();
            foreach (var song in playlist) {
                lines.Add(song.NameSong);
                lines.Add(song.NameAuthor);
                lines.Add(song.Composer);
                lines.Add(song.YearWriting.ToString());
                lines.Add(song.TextSong.Replace("\r\n", "\\n").Replace("\n", "\\n"));
                lines.Add(string.Join(",", song.Performers));
                lines.Add("===");
                File.WriteAllLines(filePath, lines);
                Console.WriteLine("Collection saved to file successfully!");
            }
        }
        public void textExportColectionInFile(string filePath) {
            Console.Write("Enter song title to display text song from file: ");
            string searchTitle = Console.ReadLine();
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found!");
                return;
            }
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i+=7) {
                if (i + 4 >= lines.Length) break;
                string checkingSongTitle=lines[i];
                if (checkingSongTitle.Equals(searchTitle, StringComparison.OrdinalIgnoreCase)) {
                    string text = lines[i + 4].Replace("\\n", Environment.NewLine);
                    Console.WriteLine($"text it`s song <<{checkingSongTitle}>> ");
                    Console.WriteLine(text);
                    return;
                }
            }
            Console.WriteLine("Such a song was not found in the file.");
        }
    }
}
