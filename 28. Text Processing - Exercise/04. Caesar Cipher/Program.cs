using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textToEncrypt = Console.ReadLine();

            StringBuilder encryptedText = new StringBuilder();

            foreach (var ch in textToEncrypt)
            {
                encryptedText.Append((char)(ch + 3));
            }

            Console.WriteLine(encryptedText);
        }
    }
}
