using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumElements = 0;
            int length = 0;
            if (arr1.Length >= arr2.Length)
                length = arr1.Length;
            else
                length = arr2.Length;

            for (int i = 0; i < length; i++)
            {
                if (!Equals(arr1[i], arr2[i]))
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                else
                    sumElements += arr1[i];
            }

            Console.WriteLine($"Arrays are identical. Sum: {sumElements}");
        }
    }
}
