using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] arr = {1};
            
            for (int i = 1; i <= lines; i++)
            {
                int[] currArr = new int[i];
                currArr[0] = 1;
                for (int j = 2; j <= i - 1; j++)
                {
                    currArr[j -1] = arr[j - 2] + arr[j -1];
                }

                currArr[i -1] = 1;
                arr = currArr;
                Console.WriteLine(string.Join(' ', arr));
            }
        }
    }
}
