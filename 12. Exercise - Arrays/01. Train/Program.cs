using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vagons = int.Parse(Console.ReadLine());
            int[] trainPassenger = new int[vagons];
            int allPassangers = 0;
            for (int currVagon = 0; currVagon < vagons; currVagon++)
            {
                trainPassenger[currVagon] = int.Parse(Console.ReadLine());
                allPassangers += trainPassenger[currVagon];
            }
            Console.WriteLine(string.Join(' ', trainPassenger));
            Console.WriteLine(allPassangers);
        }
    }
}
