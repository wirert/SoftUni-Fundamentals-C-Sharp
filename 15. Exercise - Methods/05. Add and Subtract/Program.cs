using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            
            Console.WriteLine(ResultMathOperations(num1, num2, num3));
        }

        private static int ResultMathOperations(int num1, int num2, int num3) => AddTwoNumbers(num1, num2) - num3;
        
        static int AddTwoNumbers(int num1, int num2) => num1 + num2;
    }
}
