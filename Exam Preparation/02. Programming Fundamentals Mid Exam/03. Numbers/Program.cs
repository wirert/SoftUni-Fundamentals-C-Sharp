using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            double averageValue = arr.Sum() * 1.0 / arr.Length;

            List<int> result = new List<int>();
            Array.Sort(arr);
            int count = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] > averageValue && count < 5)
                {
                    result.Add(arr[i]);
                    count++;
                }
            }

            if (result.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
