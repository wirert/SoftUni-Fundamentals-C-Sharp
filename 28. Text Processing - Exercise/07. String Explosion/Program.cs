using System;
using System.Text;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int explosion = 0;

            StringBuilder result = new StringBuilder();

            for (var i = 0; i < input.Length; i++)
            {
                var curSymbol = input[i];

                if (curSymbol == '>')
                {
                    result.Append(curSymbol);
                    explosion += int.Parse(input[i + 1].ToString());
                }
                else if (explosion == 0)
                {
                    result.Append(curSymbol);
                }
                else
                {
                    explosion--;
                }
            }

            Console.WriteLine(result);
        }
    }
}
