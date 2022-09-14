using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            char previousChar = ' ';

            foreach (var curChar in inputString)
            {
                if (curChar == previousChar)
                    continue;

                if (previousChar == ' ')
                    previousChar = curChar;
                else
                {
                    sb.Append(previousChar);
                    previousChar = curChar;
                }
            }

            sb.Append(previousChar);

            Console.WriteLine(sb);

        }
    }
}
