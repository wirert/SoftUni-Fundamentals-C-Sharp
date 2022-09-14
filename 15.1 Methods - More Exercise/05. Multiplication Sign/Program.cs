using System;

namespace _05._Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            PrintResultSign(num1, num2, num3);
        }

        private static void PrintResultSign(double num1, double num2, double num3)
        {
            int sign = Math.Sign(num1) * Math.Sign(num2) * Math.Sign(num3);

            switch (sign)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("positive");
                    break;
                default:
                    Console.WriteLine("negative");
                    break;
            }
        }
    }
}
