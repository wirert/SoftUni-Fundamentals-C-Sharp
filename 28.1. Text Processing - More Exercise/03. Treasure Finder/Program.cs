using System;
using System.Linq;
using System.Text;

namespace _03._Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string message = string.Empty;


            while ((message = Console.ReadLine()) != "find")
            {
                int index = 0;
                StringBuilder result = new StringBuilder();

                while (result.Length < message.Length)
                {
                    foreach (var digit in key)
                    {
                        if (result.Length == message.Length)
                            break;

                        result.Append((char)(message[index] - digit));
                        index++;
                    }
                }
                int startIndex = result.ToString().IndexOf('<') + 1;
                int endIndex = result.ToString().IndexOf('>');

                string treasureCoordinates = result.ToString().Substring(startIndex, endIndex - startIndex);

                startIndex = result.ToString().IndexOf('&') + 1;
                endIndex = result.ToString().LastIndexOf('&');

                string treasureType = result.ToString().Substring(startIndex, endIndex - startIndex);

                Console.WriteLine($"Found {treasureType} at {treasureCoordinates}");
            }
        }
    }
}
