using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = null;
            while ((command = Console.ReadLine()) != "END")
            {
                Console.WriteLine(IsNumPalindrome(command).ToString().ToLower());
            }
        }

        private static bool IsNumPalindrome(string command)
        {
            int num = int.Parse(command);
            if (num >=0 && num <=9)
            {
                return true;
            }

            if (command[0] == command[command.Length - 1])
            {
                return true;
            }
            return false;
        }
    }
}
