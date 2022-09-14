using System;

namespace _03._Floating_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double absNum1 = Math.Abs(num1);
            double absNum2 = Math.Abs(num2);
            double diff = Math.Abs(num1 - num2);
            
            const double epsilon = 0.000001;
            bool isEqual = false;
            if (diff < epsilon)
            {
                isEqual = true;
            }
            Console.WriteLine(isEqual);
        }
    }
}
