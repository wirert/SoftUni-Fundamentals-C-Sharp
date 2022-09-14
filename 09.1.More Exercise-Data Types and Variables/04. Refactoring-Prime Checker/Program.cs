using System;
using System.Globalization;

namespace _04._Refactoring_Prime_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            for (int number = 2; number <= range; number++)
            {
                bool isPrime = true;
                for (int divisor = 2; divisor < number; divisor++)
                {
                    if (number % divisor == 0)
                    {
                        isPrime = false;
                        Console.WriteLine($"{number} -> false");
                        break;
                    }
                }
                if (isPrime)
                    Console.WriteLine($"{number} -> true");
            }

        }
    }
}
