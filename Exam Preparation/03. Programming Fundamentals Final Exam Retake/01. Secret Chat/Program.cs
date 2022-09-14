using System;
using System.Linq;

namespace _01._Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = null;

            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] tokens = command.Split(":|:");

                switch (tokens[0])
                {
                    case "InsertSpace":
                        int index = int.Parse(tokens[1]);

                        message = message.Insert(index, " ");

                        Console.WriteLine(message);

                        break;
                    case "Reverse":
                        string textToReverse = tokens[1];

                        if (!message.Contains(textToReverse))
                        {
                            Console.WriteLine("error");
                            break;
                        }

                        int startIndex = message.IndexOf(textToReverse);
                        message = message.Remove(startIndex, textToReverse.Length);
                        textToReverse = string.Join("", textToReverse.Reverse());
                        message += textToReverse;

                        Console.WriteLine(message);

                        break;
                    case "ChangeAll":
                        string textToReplace = tokens[1];
                        string replacement = tokens[2];

                        message = message.Replace(textToReplace, replacement);

                        Console.WriteLine(message);

                        break;
                }
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
