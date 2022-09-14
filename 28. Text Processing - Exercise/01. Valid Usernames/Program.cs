using System;
using System.Linq;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ");

            foreach (var userName in userNames)
            {
                if (userName.Length < 3 || userName.Length > 16)
                    continue;

                if (userName.Any(ch => !char.IsLetterOrDigit(ch) && ch != '-' && ch != '_'))
                    continue;

                Console.WriteLine(userName);
            }
        }
    }
}
