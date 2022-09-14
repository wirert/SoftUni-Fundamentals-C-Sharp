using System;
using System.Linq;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            VowelsInString(input);
        }

        private static void VowelsInString(string input)
        {
            int vowelCount = input.Count(letter => letter is 'a' or 'o' or 'i' or 'u' or 'e');

            Console.WriteLine(vowelCount);
        }
    }
}
