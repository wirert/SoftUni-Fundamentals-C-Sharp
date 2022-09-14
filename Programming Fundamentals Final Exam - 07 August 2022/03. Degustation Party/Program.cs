using System;
using System.Collections.Generic;

namespace _03._Degustation_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = null;

            int countUnlikedMeals = 0;

            var guestCollection = new Dictionary<string, List<string>>();

            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] tokens = command.Split('-');
                string guest = tokens[1];
                string meal = tokens[2];

                switch (tokens[0])
                {
                    case "Like":

                        AddMealToCollection(guestCollection, guest, meal);

                        break;
                    case "Dislike":

                        countUnlikedMeals = RemoveMealFromCollection(guestCollection, guest, meal, countUnlikedMeals);

                        break;
                }
            }

            PrintLikedMealsCollection(guestCollection, countUnlikedMeals);
        }

        private static void AddMealToCollection(Dictionary<string, List<string>> guestCollection, string guest, string meal)
        {
            if (!guestCollection.ContainsKey(guest))
            {
                guestCollection.Add(guest, new List<string>() { meal });
                return;
            }

            if (!guestCollection[guest].Contains(meal))
            {
                guestCollection[guest].Add(meal);
            }
        }

        private static int RemoveMealFromCollection(Dictionary<string, List<string>> guestCollection, string guest, string meal, int countUnlikedMeals)
        {
            if (!guestCollection.ContainsKey(guest))
            {
                Console.WriteLine($"{guest} is not at the party.");
                return countUnlikedMeals;
            }

            if (!guestCollection[guest].Contains(meal))
            {
                Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                return countUnlikedMeals;
            }

            countUnlikedMeals++;

            guestCollection[guest].Remove(meal);
            Console.WriteLine($"{guest} doesn't like the {meal}.");
            
            return countUnlikedMeals;
        }

        private static void PrintLikedMealsCollection(Dictionary<string, List<string>> guestCollection, int countUnlikedMeals)
        {
            foreach (var guest in guestCollection)
            {
                Console.Write($"{guest.Key}: ");
                Console.WriteLine(string.Join(", ", guest.Value));
            }

            Console.WriteLine($"Unliked meals: {countUnlikedMeals}");
        }
    }
}
