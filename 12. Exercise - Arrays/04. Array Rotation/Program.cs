using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotatons = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rotatons; i++)
            {
                int[] newArr = new int[arr.Length];
                for (int j = 0; j < arr.Length; j++)
                {
                    if (j == arr.Length - 1)
                    {
                        newArr[j] = arr[0];
                    }
                    else
                        newArr[j] = arr[j + 1];
                }
                arr = newArr;
            }

            Console.WriteLine(string.Join(' ', arr));

        }
    }
}
