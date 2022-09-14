using System;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numChars = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numChars; i++)
            {
                char currChar = char.Parse(Console.ReadLine());
                sum += currChar;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
