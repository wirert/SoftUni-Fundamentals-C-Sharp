using System;

namespace _01._Data_Type_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            while ((input = Console.ReadLine()) != "END")
            {
                if (int.TryParse(input, out int i))
                    Console.WriteLine($"{input} is integer type");
                else if (float.TryParse(input, out var f))
                    Console.WriteLine($"{input} is floating point type");
                else if (char.TryParse(input, out var c))
                    Console.WriteLine($"{input} is character type");
                else if (bool.TryParse(input, out var b))
                    Console.WriteLine($"{input} is boolean type");
                else
                    Console.WriteLine($"{ input} is string type");
            }
        }
    }
}
