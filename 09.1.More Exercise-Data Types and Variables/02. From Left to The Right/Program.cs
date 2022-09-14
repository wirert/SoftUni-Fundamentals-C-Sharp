using System;
using System.Numerics;

namespace _02._From_Left_to_The_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {

                string numbers = Console.ReadLine();
                string[] parts = numbers.Split(' ');
                long num1 = long.Parse(parts[0]);
                long num2 = long.Parse(parts[1]);
                long sum = 0;
                if (num1 >= num2)
                {
                    for (int digit = 0; digit < parts[0].Length; digit++)
                    {
                        sum += num1 % 10;
                        num1 /= 10;
                    }
                }
                else
                {
                    for (int digit = 0; digit < parts[1].Length; digit++)
                    {
                        sum += num2 % 10;
                        num2 /= 10;
                    }
                }
                Console.WriteLine(Math.Abs(sum));
            }

        }
    }
}
