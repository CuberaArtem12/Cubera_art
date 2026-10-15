using lb3_3kurs2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb3_3kurs2
{
    public class CreateListSong
    {
        public static List<Song> createListSong() {
            List<Song> playlist = new List<Song>
            {
                new Song(
                    "Yesterday",
                    "Paul McCartney",
                    "Paul McCartney",
                    1965,
                    "Yesterday, all my troubles seemed so far away...",
                    new List < string > { "The Beatles" }
                ),
                new Song(
                    "Bohemian Rhapsody",
                    "Freddie Mercury",
                    "Freddie Mercury",
                    1975,
                    "Is this the real life? Is this just fantasy?...",
                    new List < string > { "Queen" }
                ),
                new Song(
                    "Chervona Ruta",
                    "Volodymyr Ivasiuk",
                    "Volodymyr Ivasiuk",
                    1970,
                    "Tell me, admit to me, where did you get those charms...",
                    new List < string > { "VIA Chervona Ruta", "Sofia Rotaru", "Nazariy Yaremchuk" }
                ),
                new Song(
                    "Shape of You",
                    "Ed Sheeran",
                    "Ed Sheeran, Steve Mac",
                    2017,
                    "The club isn't the best place to find a lover...",
                    new List < string > { "Ed Sheeran" }
                )
            };
            return playlist;
        }
        
    }
}
