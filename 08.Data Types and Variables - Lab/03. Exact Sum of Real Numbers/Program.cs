using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());
            decimal sum = 0m;
            for (int currNum = 0; currNum < countNumbers; currNum++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum+=number;
            }
            Console.WriteLine(sum);
        }
    }
}
