using System;

namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = rnd.Next(0, words.Length);
                string currWord = words[i];

                words[i] = words[randomIndex];
                words[randomIndex] = currWord;
            }
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
