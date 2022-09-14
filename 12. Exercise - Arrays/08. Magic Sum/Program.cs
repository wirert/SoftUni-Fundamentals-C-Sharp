using System;
using System.Linq;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int currSum = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    currSum = arr[i] + arr[j];
                    if (currSum == magicSum)
                    {
                        Console.WriteLine($"{arr[i]} {arr[j]}");
                    }

                }
            }

        }
    }
}
