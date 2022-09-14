using System;
using System.Linq;

namespace _01._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = null;

            while ((command = Console.ReadLine()) != "Decode")
            {
                var tokens = command.Split('|');


                switch (tokens[0])
                {
                    case "Move":
                        int numLettersToMove = int.Parse(tokens[1]);
                        string lettersToMove = message.Substring(0, numLettersToMove);
                        message = message[numLettersToMove..];
                        message += lettersToMove;
                        break;
                    case "Insert":
                        int index = int.Parse(tokens[1]);
                        var value = tokens[2];
                        message = message.Insert(index, value);
                        break;
                    case "ChangeAll":
                        message = message.Replace(tokens[1], tokens[2]);
                        break;
                }

            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
