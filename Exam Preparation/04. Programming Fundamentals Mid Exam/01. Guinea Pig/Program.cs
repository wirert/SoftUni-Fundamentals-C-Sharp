using System;

namespace _01._Guinea_Pig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float food = float.Parse(Console.ReadLine());
            float hay = float.Parse(Console.ReadLine());
            float cover = float.Parse(Console.ReadLine());
            float petWeight = float.Parse(Console.ReadLine());

            for (int day = 1; day <= 30; day++)
            {
                food -= 0.3f;
                if (day % 2 == 0)
                {
                    hay -= 0.05f * food;
                }

                if (day % 3 == 0)
                {
                    cover -= petWeight / 3;
                }

                if (food <= 0 || hay <= 0 || cover <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
            }

            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food:f2}, Hay: {hay:f2}, Cover: {cover:f2}.");
        }
    }
}
