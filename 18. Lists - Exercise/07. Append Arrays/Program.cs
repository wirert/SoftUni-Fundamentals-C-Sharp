using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);


            List<int> result = new List<int>();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int[] varInt = arr[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                result.AddRange(varInt);
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
