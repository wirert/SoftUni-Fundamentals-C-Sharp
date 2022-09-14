using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;

            while ((str = Console.ReadLine()) != "end")
            {
                var reversedString = string.Join("", str.ToCharArray().Reverse());

                Console.WriteLine($"{str} = {reversedString}");
            }
        }
    }
}
