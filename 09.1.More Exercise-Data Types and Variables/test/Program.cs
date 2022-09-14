using System;

namespace _03._Floating_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            long intNum1 = (long)(num1 * 1000000);
            long intNum2 = (long)(num2 * 1000000);
            bool isBigger = false;
            if (intNum1 >= intNum2)
            {
                isBigger = true;
            }
            Console.WriteLine(isBigger);
        }
    }
}
