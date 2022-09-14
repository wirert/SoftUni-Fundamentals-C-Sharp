using System;
using System.Text;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int timesRepeated = int.Parse(Console.ReadLine());

            Console.WriteLine(OutputString(inputString, timesRepeated));
        }

        static string OutputString(string input, int times)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < times; i++)
            {
                result.Append(input);
            }
            return result.ToString();
        }
    }
}
