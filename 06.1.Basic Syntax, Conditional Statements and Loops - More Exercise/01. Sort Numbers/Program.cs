using System;

namespace _01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            double[] numbers = { num1, num2, num3 };
            Array.Sort(numbers);
            Array.Reverse(numbers);
            foreach (double item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
