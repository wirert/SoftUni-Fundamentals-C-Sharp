using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> line = Console.ReadLine().Split().ToList();

            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "3:1")
            {
                switch (command[0])
                {
                    case "merge":
                        MergeStrings(line, command);
                        break;
                    case "divide":
                        DivideString(line, command);
                        break;
                }

                command = Console.ReadLine().Split(' ');
            }

            Console.WriteLine(string.Join(' ', line));
        }

        private static List<string> DivideString(List<string> line, string[] command)
        {
            int index = int.Parse(command[1]);
            int parts = int.Parse(command[2]);
            string word = line[index];
            int countChars = 0;
            for (int i = 0; i < parts; i++)
            {
                string newWord = null;
                for (int j = 0; j < word.Length / parts; j++)
                {
                    newWord += word[countChars];
                    countChars++;
                }

                if (word.Length % parts != 0 && i == parts - 1)
                {
                    for (int j = 0; j < word.Length % parts; j++)
                    {
                        newWord += word[countChars];
                        countChars++;
                    }
                }
                line.Insert(index + i, newWord);
            }

            line.Remove(word);

            return line;
        }

        private static List<string> MergeStrings(List<string> line, string[] command)
        {
            int start = Math.Max(0, int.Parse(command[1]));
            int end = Math.Min(int.Parse(command[2]), line.Count - 1);

            for (int i = start; i < end; i++)
            {
                line[start] += line[start + 1];
                line.RemoveAt(start + 1);
            }
            return line;
        }
    }
}
