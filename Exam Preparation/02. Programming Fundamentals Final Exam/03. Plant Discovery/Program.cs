using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listPlants = new Dictionary<Plant, List<double>>();

            int numPlants = int.Parse(Console.ReadLine());

            CreateListOfPlants(numPlants, listPlants);

            string command = null;

            while ((command = Console.ReadLine()) != "Exhibition")
            {
                char[] pattern = { ':', '-', ' ' };
                string[] tokens = command.Split(pattern, StringSplitOptions.RemoveEmptyEntries);

                UpdateListOfPlants(tokens, listPlants);
            }

            PrintFinalList(listPlants);
        }

        private static void CreateListOfPlants(int numPlants, Dictionary<Plant, List<double>> listPlants)
        {
            for (int i = 1; i <= numPlants; i++)
            {
                string[] plantInfo = Console.ReadLine().Split("<->");

                string name = plantInfo[0];
                int rarity = int.Parse(plantInfo[1]);


                if (listPlants.Keys.Any(plant => plant.Name == name))
                {
                    listPlants.Keys.First(plant => plant.Name == name).ChangeRarity(rarity);
                    continue;
                }

                Plant plant = new Plant(name, rarity);
                listPlants.Add(plant, new List<double>());
            }
        }

        private static void UpdateListOfPlants(string[] tokens, Dictionary<Plant, List<double>> listPlants)
        {
            string name = tokens[1];

            if (listPlants.Keys.All(plant => plant.Name != name))
            {
                Console.WriteLine("error");
                return;
            }

            switch (tokens[0])
            {
                case "Rate":
                    double rating = double.Parse(tokens[2]);

                    listPlants.First(plant => plant.Key.Name == name).Value.Add(rating);

                    break;
                case "Update":
                    int newRarity = int.Parse(tokens[2]);

                    listPlants.Keys.First(plant => plant.Name == name).ChangeRarity(newRarity);

                    break;
                case "Reset":

                    listPlants.First(plant => plant.Key.Name == name).Value.Clear();

                    break;
            }
        }

        private static void PrintFinalList(Dictionary<Plant, List<double>> listPlants)
        {
            Console.WriteLine("Plants for the exhibition:");

            foreach (var plant in listPlants)
            {
                double averageRating = 0;
                if (plant.Value.Count > 0)
                {
                    averageRating = plant.Value.Average();
                }

                Console.WriteLine($"- {plant.Key.Name}; Rarity: {plant.Key.Rarity}; Rating: {averageRating:f2}");
            }
        }
    }

    class Plant
    {
        public Plant(string name, int rarity)
        {
            this.Name = name;
            this.Rarity = rarity;
        }

        public string Name { get; set; }
        public int Rarity { get; set; }

        public int ChangeRarity(int rarity) => this.Rarity = rarity;
    }
}
