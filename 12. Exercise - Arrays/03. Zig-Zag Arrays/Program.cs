using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] firstArray = new int[lines];
            int[] secondArray = new int[lines];
            for (int i = 0; i < lines; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 != 0)
                {
                    firstArray[i] = input[1];
                    secondArray[i] = input[0];
                }
                else
                {
                    firstArray[i] = input[0];
                    secondArray[i] = input[1];
                }
            }
            Console.WriteLine(string.Join(' ', firstArray));
            Console.WriteLine(string.Join(' ', secondArray));
        }
    }
}
