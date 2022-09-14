using System;

namespace _01._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string[] command = Console.ReadLine().Split(">>>");

            while (command[0] != "Generate")
            {
                switch (command[0])
                {
                    case "Contains":

                        PrintWhetherAKeyContainsGivenText(command, activationKey);
                        break;
                    case "Flip":

                        activationKey = ToUpperOrToLowerPartOfTheKey(command, activationKey);
                        break;
                    case "Slice":

                        activationKey = RemoveTextFromKey(command, activationKey);
                        break;
                }

                command = Console.ReadLine().Split(">>>");
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }

        private static void PrintWhetherAKeyContainsGivenText(string[] command, string activationKey)
        {
            string substring = command[1];

            Console.WriteLine(activationKey.Contains(substring)
                ? $"{activationKey} contains {substring}"
                : "Substring not found!");
        }

        private static string ToUpperOrToLowerPartOfTheKey(string[] command, string activationKey)
        {
            string upperOrLower = command[1];
            int startIndex = int.Parse(command[2]);
            int endIndex = int.Parse(command[3]);

            string textToChange = activationKey.Substring(startIndex, endIndex - startIndex);

            string changedText = upperOrLower == "Upper" ? textToChange.ToUpper() : textToChange.ToLower();

            activationKey = activationKey.Replace(textToChange, changedText);

            Console.WriteLine(activationKey);
            return activationKey;
        }

        private static string RemoveTextFromKey(string[] command, string activationKey)
        {
            int startIndex = int.Parse(command[1]);
            int endIndex = int.Parse(command[2]);

            activationKey = activationKey.Remove(startIndex, endIndex - startIndex);

            Console.WriteLine(activationKey);
            return activationKey;
        }
    }
}
