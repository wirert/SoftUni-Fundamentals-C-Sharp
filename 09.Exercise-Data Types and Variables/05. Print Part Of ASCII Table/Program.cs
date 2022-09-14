using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstChar = int.Parse(Console.ReadLine());
            int lastChar = int.Parse(Console.ReadLine());
            for (int currChar = firstChar; currChar <= lastChar; currChar++)
            {
                Console.Write($"{(char)currChar} ");
            }
        }
    }
}
