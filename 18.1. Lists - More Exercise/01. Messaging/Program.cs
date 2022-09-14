using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string text = Console.ReadLine();
            string output = null;

            for (int i = 0; i < numbers.Count; i++)
            {
                int index = 0;

                while (numbers[i] != 0)
                {
                    index += numbers[i] % 10;
                    numbers[i] /= 10;
                }

                if (index < text.Length)
                {
                    output += text[index];
                    text = text.Remove(index, 1);
                }
                else
                {
                    index = index - (index / text.Length) * text.Length;
                    output += text[index];
                    text = text.Remove(index, 1);
                }

            }

            Console.WriteLine(output);
        }
    }
}
