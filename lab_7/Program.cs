using System;
using System.Collections.Generic;

namespace lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();

            for (int i = 0; i < 4; i++)
            {
                Song song = new Song();
                song.SetName($"Song {i + 1}");
                song.SetAuthor($"Author {i + 1}");
                songs.Add(song);
            }

            foreach (var song in songs)
            {
                Console.WriteLine(song.Title());
            }

            if (songs[0].Equals(songs[1]))
            {
                Console.WriteLine("Первая и вторая песни одинаковые.");
            }
            else
            {
                Console.WriteLine("Первая и вторая песни разные.");
            }
        }
    }
}