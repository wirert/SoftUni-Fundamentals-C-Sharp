using System;

namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string textToFilter = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                textToFilter = textToFilter.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(textToFilter);
        }
    }
}
