using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var charCountsInText = new Dictionary<char, int>();

            foreach (var character in text)
            {
                if (character == ' ')
                    continue;
                if (!charCountsInText.ContainsKey(character))
                    charCountsInText.Add(character, 0);
                charCountsInText[character]++;
            }

            foreach (var character in charCountsInText)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}
