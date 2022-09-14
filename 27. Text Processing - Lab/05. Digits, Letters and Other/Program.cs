using System;
using System.Linq;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            char[] digits = inputString.Where(char.IsDigit).ToArray();
            char[] letters = inputString.Where(char.IsLetter).ToArray();
            char[] otherCharacters = inputString.Where(ch => !char.IsLetterOrDigit(ch)).ToArray();

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(otherCharacters);
        }
    }
}

            //StringBuilder digits = new StringBuilder();
            //StringBuilder letters = new StringBuilder();
            //StringBuilder otherCharacters = new StringBuilder();

            //foreach (var character in inputString)
            //{
            //    if (char.IsDigit(character))
            //        digits.Append(character);
            //    else if (char.IsLetter(character))
            //        letters.Append(character);
            //    else
            //        otherCharacters.Append(character);
            //}