using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputStrings = Console.ReadLine().Split();

            PrintSumOfMultipliedCharsOfTwoStrings(inputStrings);
        }

        private static void PrintSumOfMultipliedCharsOfTwoStrings(string[] inputStrings)
        {
            string shortStr = inputStrings[0].Length > inputStrings[1].Length ? inputStrings[1] : inputStrings[0];
            string longStr = inputStrings[0].Length <= inputStrings[1].Length ? inputStrings[1] : inputStrings[0];

            int resultSum = 0;

            for (int i = 0; i < shortStr.Length; i++)
            {
                resultSum += shortStr[i] * longStr[i];
            }

            if (shortStr.Length != longStr.Length)
            {
                longStr = longStr.Substring(shortStr.Length);

                foreach (var ch in longStr)
                {
                    resultSum += ch;
                }
            }

            Console.WriteLine(resultSum);
        }
    }
}
