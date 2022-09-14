﻿using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isMaxNum = true;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] <= numbers[j])
                    {
                        isMaxNum = false;
                        break;
                    }
                }

                if (isMaxNum)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
        }
    }
}
