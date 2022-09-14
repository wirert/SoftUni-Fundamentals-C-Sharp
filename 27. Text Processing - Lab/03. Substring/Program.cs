using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string textToRemoveFrom = Console.ReadLine();

            while (textToRemoveFrom.Contains(wordToRemove))
            {
                int index = textToRemoveFrom.IndexOf(wordToRemove);
                textToRemoveFrom = textToRemoveFrom.Remove(index, wordToRemove.Length);

                //textToRemoveFrom = textToRemoveFrom.Replace(wordToRemove, "");  - another solution
            }

            Console.WriteLine(textToRemoveFrom);
        }
    }
}
