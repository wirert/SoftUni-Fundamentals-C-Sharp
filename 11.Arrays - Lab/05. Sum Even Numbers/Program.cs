﻿using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            foreach (var number in arr)
            {
                if (number % 2 == 0)
                    sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
