using System;
using System.Text;

namespace _02._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            int result = 0;

            foreach (var ch in text)
            {
                if (ch > firstChar && ch < secondChar)
                {
                    result += ch;
                }
            }

            Console.WriteLine(result);
        }
    }
}
