using System;

namespace _05._Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numSymbols = int.Parse(Console.ReadLine());
            string word = null;
            for (int currSymbol = 1; currSymbol <= numSymbols; currSymbol++)
            {
                char letter = char.Parse(Console.ReadLine());
                letter = (char)(letter + key);
                word += letter;

            }
            Console.WriteLine(word);
        }
    }
}
