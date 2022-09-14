using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            for (int i = 17; i <= range; i++)
            {
                if (!IsSumDivisibleBy8(i))
                    continue;
                if (!IsNumHasOddDigits(i))
                    continue;
                Console.WriteLine(i);
            }
        }

        private static bool IsNumHasOddDigits(int num)
        {
            while (num != 0)
            {
                int digit = num % 10;
                if (digit % 2 == 1)
                    return true;

                num /= 10;
            }

            return false;
        }

        private static bool IsSumDivisibleBy8(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            if (sum % 8 == 0)
                return true;
            return false;
        }
    }
}
