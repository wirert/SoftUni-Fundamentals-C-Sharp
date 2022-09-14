using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "adfvй45ажaaa";
            foreach (var expr in a)
            {
                if (Char.IsLetter(expr))
                {
                    Console.Write(expr.ToString() + ' ');
                }
            }
        }
    }
}
