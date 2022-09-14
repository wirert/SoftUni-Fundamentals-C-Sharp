using System;

namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintLineAscend(1, input);
            PrintLineDescend(input, 1);

        }

        static void PrintLineAscend(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                for (int j = start; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }

        }

        static void PrintLineDescend(int startDescend, int endDescend)
        {
            for (int i = startDescend; i >= endDescend; i--)
            {
                for (int j = endDescend; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
