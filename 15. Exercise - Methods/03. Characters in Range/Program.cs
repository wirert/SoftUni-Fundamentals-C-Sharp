using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            char startChar = (char)Math.Min(char1, char2);
            char endChar = (char)Math.Max(char1, char2);

            PrintCharsBetween(startChar, endChar);
        }

        private static void PrintCharsBetween(char start, char end)
        {
            for (int i = start +1; i < end; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }


}
