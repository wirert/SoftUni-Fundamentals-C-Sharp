using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                if (command[0] == "exchange")
                {
                    arr = ExchangeIndexPlaces(arr, int.Parse(command[1]));
                }

                else if (command[0] == "max" || command[0] == "min")
                {
                    FindMaxMinEvenOddElement(arr, command[0], command[1]);
                }
                else
                {
                    FindFirstLastCountElements(arr, command[0], int.Parse(command[1]), command[2]);
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        private static void FindFirstLastCountElements(int[] arr, string firstLast, int numDigitsToCount, string evenOdd)
        {
            if (numDigitsToCount < 0 || numDigitsToCount > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int evenOrOdd = 0;

            if (evenOdd == "odd")
                evenOrOdd = 1;

            int count = 0;
            List<int> list = new List<int>();

            if (firstLast == "first")
            {
                for (int i = 0; i < arr.Length; i++)
                {

                    if (arr[i] % 2 == evenOrOdd)
                    {
                        count++;
                        list.Add(arr[i]);
                        if (count == numDigitsToCount)
                            break;
                    }
                }
            }
            else
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {

                    if (arr[i] % 2 == evenOrOdd)
                    {
                        count++;
                        list.Add(arr[i]);

                        if (count == numDigitsToCount)
                            break;
                    }
                }

                list.Reverse();
            }

            if (count == 0)
            {
                Console.WriteLine("[]");
                return;
            }

            Console.WriteLine($"[{string.Join(", ", list)}]");
        }

        private static void FindMaxMinEvenOddElement(int[] arr, string minMax, string evenOdd)
        {
            int index = -1;
            int minDigit = int.MaxValue;
            int maxDigit = int.MinValue;
            int evenOrOdd = 0;

            if (evenOdd == "odd")
                evenOrOdd = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == evenOrOdd)
                {
                    if (minMax == "max" && maxDigit <= arr[i])
                    {
                        maxDigit = arr[i];
                        index = i;
                    }
                    else if (minMax == "min" && minDigit >= arr[i])
                    {
                        minDigit = arr[i];
                        index = i;
                    }

                }

            }

            if (index != -1)
                Console.WriteLine(index);
            else
                Console.WriteLine("No matches");
        }

        private static int[] ExchangeIndexPlaces(int[] arr, int splitIndex)
        {
            if (splitIndex < 0 || splitIndex >= arr.Length)
            {
                Console.WriteLine("Invalid index");
                return arr;
            }

            int[] newArr = new int[arr.Length];
            int index = 0;

            for (int i = splitIndex + 1; i < arr.Length; i++)
            {
                newArr[index] = arr[i];
                index++;
            }

            for (int i = 0; i <= splitIndex; i++)
            {
                newArr[index] = arr[i];
                index++;
            }

            return newArr;
        }

    }
}
