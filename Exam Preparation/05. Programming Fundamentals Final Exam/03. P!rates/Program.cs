using System;
using System.Collections.Generic;

namespace _03._P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cities = new Dictionary<string, City>();

            AddCitiesToDictionary(cities);

            string command = null;

            while ((command = Console.ReadLine()) != "End" )
            {
                var tokens = command.Split("=>");


                switch (tokens[0])
                {
                    case "Plunder":

                        PlunderTown(tokens, cities);

                        break;
                    case "Prosper":

                        ProsperTown(tokens, cities);

                        break;
                }
            }

            PrintRemainingCities(cities);
        }

        private static void AddCitiesToDictionary(Dictionary<string, City> cities)
        {
            string commandCity = null;

            while ((commandCity = Console.ReadLine()) != "Sail")
            {
                string[] inputCity = commandCity.Split("||");

                string cityName = inputCity[0];
                int population = int.Parse(inputCity[1]);
                int gold = int.Parse(inputCity[2]);

                if (cities.ContainsKey(cityName))
                {
                    cities[cityName].Population += population;
                    cities[cityName].Gold += gold;
                    continue;
                }

                cities.Add(cityName, new City(cityName, population, gold));
            }
        }

        private static void PlunderTown(string[] tokens, Dictionary<string, City> cities)
        {
            var town = tokens[1];
            var people = int.Parse(tokens[2]);
            var gold = int.Parse(tokens[3]);

            Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

            cities[town].Population -= people;
            cities[town].Gold -= gold;

            if (cities[town].Gold != 0 && cities[town].Population != 0) return;

            cities.Remove(town);
            Console.WriteLine($"{town} has been wiped off the map!");
        }

        private static void ProsperTown(string[] tokens, Dictionary<string, City> cities)
        {
            var town = tokens[1];
            var gold = int.Parse(tokens[2]);

            if (gold < 0)
            {
                Console.WriteLine("Gold added cannot be a negative number!");
                return;
            }

            cities[town].Gold += gold;
            Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town].Gold} gold.");
        }

        private static void PrintRemainingCities(Dictionary<string, City> cities)
        {
            if (cities.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
                return;
            }

            Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

            foreach (var town in cities)
            {
                Console.WriteLine(town.Value);
            }
        }
    }

    class City
    {
        public City(string name, int population, int gold)
        {
            Name = name;
            Population = population;
            Gold = gold;
        }
        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }

        public override string ToString()
        {
            return $"{Name} -> Population: {Population} citizens, Gold: {Gold} kg";
        }
    }
}
