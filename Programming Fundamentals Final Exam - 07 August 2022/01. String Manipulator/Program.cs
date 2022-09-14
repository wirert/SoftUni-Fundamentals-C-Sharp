using System;

namespace _01._String_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string command = null;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case "Translate":
                        text = ReplaceCharWithAnother(tokens, text);
                        break;
                    case "Includes":
                        WhetherTextIncludesSubstring(tokens, text);
                        break;
                    case "Start":
                        WhetherTextStartWithGivenString(tokens, text);
                        break;
                    case "Lowercase":
                        text = PrintTextLowercased(text);
                        break;
                    case "FindIndex":
                        FindIndexAndPrintIt(tokens, text);
                        break;
                    case "Remove":
                        text = Remove(tokens, text);
                        break;
                }

            }

        }

        private static string Remove(string[] tokens, string text)
        {
            int startIndex = int.Parse(tokens[1]);
            int count = int.Parse(tokens[2]);

            text = text.Remove(startIndex, count);

            Console.WriteLine(text);

            return text;
        }

        private static void FindIndexAndPrintIt(string[] tokens, string text)
        {
            char symbol = char.Parse(tokens[1]);
            int index = text.LastIndexOf(symbol);
            Console.WriteLine(index);
        }

        private static string PrintTextLowercased(string text)
        {
            text = text.ToLower();
            Console.WriteLine(text);
            return text;
        }

        private static void WhetherTextStartWithGivenString(string[] tokens, string text)
        {
            string substring = tokens[1];

            bool isStartWithSubstring = false;
            if (text.Contains(substring))
            {
                int index = text.IndexOf(substring);

                if (index == 0)
                {
                    isStartWithSubstring = true;
                }
            }

            Console.WriteLine(isStartWithSubstring);
        }

        private static void WhetherTextIncludesSubstring(string[] tokens, string text)
        {
            string substring = tokens[1];

            Console.WriteLine(text.Contains(substring) ? "True" : "False");
        }

        private static string ReplaceCharWithAnother(string[] tokens, string text)
        {
            char symbolToReplace = char.Parse(tokens[1]);
            char replacement = char.Parse(tokens[2]);

            text = text.Replace(symbolToReplace, replacement);

            Console.WriteLine(text);

            return text;
        }
    }
}
