using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int currNum = num;
            while (currNum != 0)
            {
                int numFact = currNum % 10;
                currNum = currNum / 10;
                int factorial = 1;
                for (int i = 2; i <= numFact; i++)
                {
                    factorial *= i;
                }
                sum += factorial;
            }
            if (sum == num)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}
