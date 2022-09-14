using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            for (int n = 1; n <= range; n++)
            {
                int currNum = n;
                bool isSpecial = false;
                int sum = 0;
                while (currNum != 0)
                {
                    int currDigit = currNum % 10;
                    sum += currDigit;
                    currNum /= 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;
                }
                Console.WriteLine($"{n} -> {isSpecial}");

            }
        }
    }
}
