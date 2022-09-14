using System;

namespace _06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numChars  = int.Parse(Console.ReadLine());
            char lastChar = (char)('a' + numChars);
            for (char char1 = 'a'; char1 < lastChar; char1++)
            {
                for (char char2 = 'a'; char2 < lastChar; char2++)
                {
                    for (char char3 = 'a'; char3 < lastChar; char3++)
                    {   
                        Console.WriteLine($"{char1}{char2}{char3}");
                    }
                }
            }
        }
    }
}
