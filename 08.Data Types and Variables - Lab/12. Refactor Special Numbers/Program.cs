using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            for (int n = 1; n <= range; n++)
            {
                int sum = 0;
                int currNumber = n;
                while (currNumber > 0)
                {
                    sum += currNumber % 10;
                    currNumber = currNumber / 10;
                }
                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", n, isSpecial);
            }
        }
    }
}
