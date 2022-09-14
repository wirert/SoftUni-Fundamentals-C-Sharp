using System;
using System.Numerics;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int power  = int.Parse(Console.ReadLine());
            int powerLeft = power;
            int distanceToTargets = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int numPokes = 0;

            while (distanceToTargets <= powerLeft)
            {
                powerLeft -= distanceToTargets;
                numPokes++;
                if (powerLeft == power/ 2.0 && exhaustionFactor > 0)
                {
                    powerLeft /= exhaustionFactor;
                }
            }
            Console.WriteLine(powerLeft);
            Console.WriteLine(numPokes);

        }
    }
}
