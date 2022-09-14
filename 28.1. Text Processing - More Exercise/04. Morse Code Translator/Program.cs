using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Morse_Code_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char> morseCode = new Dictionary<string, char>()
            {
                {".-", 'A'}, {"-...", 'B'}, {"-.-.", 'C'}, {"-..", 'D'}, {".", 'E'},{"..-.", 'F'}, { "--.", 'G'}, {"....", 'H'},{"..", 'I'}, {".---", 'J'}, {"-.-", 'K'}, {".-..", 'L'}, {"--", 'M'}, {"-.", 'N'}, {"---", 'O'}, {".--.", 'P'}, {"--.-", 'Q'}, {".-.", 'R'}, {"...", 'S'}, {"-", 'T'}, {"..-", 'U'}, {"...-", 'V'}, {".--", 'W'}, {"-..-", 'X'}, {"-.--", 'Y'}, {"--..", 'Z'}
            };

            string[] textToTranslate = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries);

            StringBuilder translatedText = new StringBuilder();

            foreach (var str in textToTranslate)
            {
                string[] word = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (var letter in word)
                {
                    translatedText.Append(morseCode[letter]);
                }

                translatedText.Append(' ');
            }

            Console.WriteLine(translatedText);
        }
    }
}
