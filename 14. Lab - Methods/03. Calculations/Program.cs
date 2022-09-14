using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            PrintResult(operation, num1, num2);
        }

        static void PrintResult(string operation, double num1, double num2)
        {
            double result = 0;
            switch (operation)
            {
                case "add":
                    result = num1 + num2;
                    break;
                case "multiply":
                    result = num1 * num2;
                    break;
                case "subtract":
                    result = num1 - num2;
                    break;
                default:
                    result = num1 / num2;
                    break;
            }

            Console.WriteLine(result);
        }
    }
}
