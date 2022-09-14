using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = 0;
            int leftSum = 0;
            if (input.Length == 1)
            {
                Console.WriteLine(index);
                return;
            }
            for (int i = 0; i <= input.Length - 1; i++)
            {
                int rightSum = 0;
                for (int j = input.Length; j >= i + 1; j--)
                {
                    if (j != input.Length)
                        rightSum += input[j];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(index);
                    return;
                }
                leftSum += input[i];
                index++;

            }

            Console.WriteLine("no");

        }
    }
}
