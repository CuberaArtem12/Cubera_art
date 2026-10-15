using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace lb3_3kurs2.Model
{
    public class Song
    {
        public string NameSong { get; set; }
        public string NameAuthor { get; set; }
        public string Composer { get; set; }
        public int YearWriting { get; set; }
        public string TextSong { get; set; }
        public List<string> Performers { get; set; } = new List<string>();
        public Song()
        {
            NameSong = string.Empty;
            NameAuthor = string.Empty;
            Composer = string.Empty;
            YearWriting =0;
            TextSong = string.Empty;
            Performers = new List<string>();
        }

        public Song(string nameSong, string nameAuthor, string composer, int yearWriting, string textSong, List<string> performers)
        {
            NameSong = nameSong;
            NameAuthor = nameAuthor;
            Composer = composer;
            YearWriting = yearWriting;
            TextSong = textSong;
            Performers = performers;
        }
        public override string ToString()
        {
            return $"\"{NameSong}\" ({YearWriting}) | Author: {NameAuthor} | Composer: {Composer}\nPerformers: {string.Join(", ", Performers)}\nТекст:\n{TextSong}\n";
        }
    }
}
