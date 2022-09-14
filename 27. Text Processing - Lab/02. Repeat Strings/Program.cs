using System;
using System.Linq;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputStrings = Console.ReadLine().Split(' ');

            string outputStrings = (from word in inputStrings from t in word select word)
                                .Aggregate(string.Empty, (current, word) => current + word);
            Console.WriteLine(outputStrings);
        }
    }
}
