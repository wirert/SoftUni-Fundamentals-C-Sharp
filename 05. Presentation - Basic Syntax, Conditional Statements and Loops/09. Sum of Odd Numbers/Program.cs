using System;

namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOdds = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= numOdds; i++)
            {
                int currOdd = i * 2 - 1;
                sum += currOdd;
                Console.WriteLine(currOdd);
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
