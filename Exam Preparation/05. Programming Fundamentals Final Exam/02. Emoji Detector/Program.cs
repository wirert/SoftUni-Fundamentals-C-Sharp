using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            ulong coolThreshold = 1;

            foreach (var symbol in inputText.Where(char.IsDigit))
            {
                coolThreshold *= uint.Parse(symbol.ToString());
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");

            string pattern = @"([*]{2}|[:]{2})(?<text>[A-Z][a-z]{2,})\1";

            var emojis = Regex.Matches(inputText, pattern);
            
            Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");

            foreach (Match emoji in emojis)
            {
                ulong sumLetters = 0;

                foreach (var letter in emoji.Groups["text"].Value)
                {
                    sumLetters += letter;
                }

                if (sumLetters < coolThreshold) continue;

                Console.WriteLine(emoji);
            }

        }
    }
}
