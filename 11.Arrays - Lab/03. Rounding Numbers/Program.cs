using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            foreach (var number in arr)
            {
                Console.WriteLine($"{number} => {(int)Math.Round(number, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
