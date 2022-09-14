using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var countedNumbers = new SortedDictionary<int, int>();

            foreach (var number in numbers)
            {
                if (!countedNumbers.ContainsKey(number))
                {
                    countedNumbers.Add(number, 0);
                }

                countedNumbers[number]++;
            }

            foreach (var number in countedNumbers)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
