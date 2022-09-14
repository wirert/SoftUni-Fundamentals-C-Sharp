using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 1; i <= numSongs; i++)
            {
                string[] tokens = Console.ReadLine().Split('_');

                Song song = new Song();

                song.TypeList = tokens[0];
                song.Name = tokens[1];
                song.Time = tokens[2];

                songs.Add(song);
            }

            string command = Console.ReadLine();

            if (command == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs.Where(song => song.TypeList == command))
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }

    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
