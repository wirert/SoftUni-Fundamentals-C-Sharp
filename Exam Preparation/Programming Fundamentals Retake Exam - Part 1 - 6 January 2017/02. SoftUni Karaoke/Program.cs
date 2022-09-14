using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._SoftUni_Karaoke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string splitPattern = @", ";
            string[] participants = Console.ReadLine().Split(splitPattern);
            
            string[] availableSongs = Console.ReadLine().Split(splitPattern);
            
            var singersList = new Dictionary<string, List<string>>();

            string command = null;

            while ((command = Console.ReadLine()) != "dawn")
            {
                AddAwardToListIfValid(command, participants, availableSongs, singersList);
            }

            PrintAwards(singersList);
        }

        private static void AddAwardToListIfValid(string command, string[] participants, string[] availableSongs,
            Dictionary<string, List<string>> singersList)
        {
            string splitPattern = @", ";
            string[] tokens = command.Split(splitPattern);
            
            string singer = tokens[0];
            string song = tokens[1];
            string award = tokens[2];

            if (!participants.Contains(singer) || !availableSongs.Contains(song)) return;

            if (!singersList.ContainsKey(singer))
            {
                singersList.Add(singer, new List<string>());
            }

            if (singersList[singer].Contains(award)) return;

            singersList[singer].Add(award);
        }

        private static void PrintAwards(Dictionary<string, List<string>> singersList)
        {
            if (singersList.Values.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            foreach (var singer in singersList
                         .OrderByDescending(x => x.Value.Count)
                         .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{singer.Key}: {singer.Value.Count} awards");

                foreach (var award in singer.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}
