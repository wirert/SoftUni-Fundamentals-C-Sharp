using System;
using System.Globalization;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(MultipleOfEvenAndOdds(number));
        }

        static int MultipleOfEvenAndOdds(int number)
        {
            return OddDigitsSum(number) * EvenDigitsSum(number);
        }
        static int OddDigitsSum(int number)
        {
            int oddSum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    oddSum += digit;
                }
                number /= 10;
            }
            return oddSum;
        }

        static int EvenDigitsSum(int number)
        {
            int evenSum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }
                number /= 10;
            }
            return evenSum;
        }

    }
}
