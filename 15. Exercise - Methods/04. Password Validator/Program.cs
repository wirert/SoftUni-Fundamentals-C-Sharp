using System;
using System.Threading;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (!IsCorrectNumberChar(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!IsLettersAndDigitsOnly(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!IsDigitsAtLeast2(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (IsCorrectPassword(password))
            {
                Console.WriteLine("Password is valid");
            }

        }

        private static bool IsCorrectPassword(string password)
        {
            if (IsCorrectNumberChar(password) && IsLettersAndDigitsOnly(password) && IsDigitsAtLeast2(password)) return true;
            return false;
        }

        private static bool IsDigitsAtLeast2(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                {
                    count++;
                }
            }

            if (count < 2) return false;
            return true;

        }

        private static bool IsLettersAndDigitsOnly(string word)
        {
            foreach (char symbol in word)
            {
                if (!char.IsLetterOrDigit(symbol))
                    return false;
            }

            return true;
        }

        private static bool IsCorrectNumberChar(string word)
        {
            if (word.Length < 6 || word.Length > 10) return false;
            return true;
        }
    }
}
