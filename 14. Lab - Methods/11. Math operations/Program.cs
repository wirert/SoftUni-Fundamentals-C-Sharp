using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(num1, @operator, num2));
        }

        static double Calculate(int num1, char @operator, int num2)
        {
            switch (@operator)
            {
                case '*': return num1 * num2;
                case '+': return num1 + num2;
                case '-': return num1 - num2;
                default: return num1 / num2;
            }

        }

    }
}
