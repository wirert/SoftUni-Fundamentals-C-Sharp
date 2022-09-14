using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CAPACITY = 255;
            int numPours = int.Parse(Console.ReadLine());
            int filledQuantity = 0;
            for (int i = 1; i <= numPours; i++)
            {
                int currLitersPoured = int.Parse(Console.ReadLine());
                if (filledQuantity + currLitersPoured > CAPACITY)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                    filledQuantity+=currLitersPoured;
            }
            Console.WriteLine(filledQuantity);
        }
    }
}
