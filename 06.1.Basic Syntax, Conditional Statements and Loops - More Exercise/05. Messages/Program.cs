using System;

namespace _05._Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numLetters = int.Parse(Console.ReadLine());
            string word = null;
            string[] keypad = { " ", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            for (int i = 1; i <= numLetters; i++)
            {
                int currLetterCode = int.Parse(Console.ReadLine());
                int currLetterDigit = currLetterCode % 10;
                int digitCount = 0;
                while (currLetterCode != 0)
                {
                    currLetterCode /= 10;
                    digitCount++;
                }
                if (currLetterDigit != 0 && currLetterDigit != 1)
                {
                    word += keypad[currLetterDigit][digitCount - 1];
                }
                else
                    word += keypad[currLetterDigit];
            }
            Console.WriteLine(word);
        }
    }
}
