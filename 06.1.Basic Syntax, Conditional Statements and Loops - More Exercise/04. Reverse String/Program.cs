﻿using System;

namespace _04._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                char letter = word[i];
                Console.Write(letter);
            }
            
        }
    }
}
