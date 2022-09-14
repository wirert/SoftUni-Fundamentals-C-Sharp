using System;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            foreach (var str in input)
            {
                char firstLetter = str[0];
                char lastLetter = str[str.Length - 1];

                double number = double.Parse(str.Substring(1, str.Length - 2));

                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    number /= firstLetter - 64;
                }
                else
                {
                    number *= firstLetter - 96;
                }

                if (lastLetter >= 65 && lastLetter <= 90)
                {
                    number -= lastLetter - 64;
                }
                else
                {
                    number += lastLetter - 96;
                }

                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
