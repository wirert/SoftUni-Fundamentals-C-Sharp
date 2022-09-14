using System;
using System.Linq;
using System.Text;

namespace _01._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string command = null;

            while ((command = Console.ReadLine()) != "Done")
            {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);


                switch (tokens[0])
                {
                    case "TakeOdd":

                        password = TakeOddElementsFromPassword(password);

                        break;
                    case "Cut":

                        password = CutTextFromPassword(tokens, password);

                        break;
                    case "Substitute":

                        password = ReplaceTextInPassword(tokens, password);

                        break;
                }
            }

            Console.WriteLine($"Your password is: {password}");
        }

        private static string TakeOddElementsFromPassword(string password)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < password.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sb.Append(password[i]);
                }
            }

            Console.WriteLine(sb);
            password = sb.ToString();
            return password;
        }

        private static string CutTextFromPassword(string[] tokens, string password)
        {
            int index = int.Parse(tokens[1]);
            int length = int.Parse(tokens[2]);

            string textToCut = password.Substring(index, length);

            index = password.IndexOf(textToCut);

            password = password.Remove(index, length);

            Console.WriteLine(password);
            return password;
        }

        private static string ReplaceTextInPassword(string[] tokens, string password)
        {
            string substring = tokens[1];
            string substitude = tokens[2];

            if (!password.Contains(substring))
            {
                Console.WriteLine("Nothing to replace!");
                return password;
            }

            password = password.Replace(substring, substitude);
            Console.WriteLine(password);
            return password;
        }
    }
}
