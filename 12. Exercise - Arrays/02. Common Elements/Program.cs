using System;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            foreach (var text1 in secondArray)
            {
                foreach (var text2 in firstArray)
                {
                    if (Equals(text1, text2))
                    {
                        Console.Write($"{text1} ");
                    }
                }
            }
        }
    }
}
