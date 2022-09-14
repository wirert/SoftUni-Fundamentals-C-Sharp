using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Dragon_Army
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dragonsList = new Dictionary<string, List<Dragon>>();

            int numDragons = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numDragons; i++)
            {
                string[] dragonInfo = Console.ReadLine().Split(' ');
                string typeDragon = dragonInfo[0];
                string name = dragonInfo[1];
                string damage = dragonInfo[2];
                string health = dragonInfo[3];
                string armor = dragonInfo[4];

                if (!dragonsList.ContainsKey(typeDragon))
                {
                    dragonsList.Add(typeDragon, new List<Dragon>());
                }
                Dragon dragon = new Dragon(name, damage, health, armor);

                if (!dragonsList[typeDragon].Exists(d => d.Name == name))
                {
                    dragonsList[typeDragon].Add(dragon);
                }
                else
                {
                    dragonsList[typeDragon].Remove(dragonsList[typeDragon].First(d => d.Name == name));
                    dragonsList[typeDragon].Add(dragon);
                }
            }

            foreach (var type in dragonsList)
            {
                Console.WriteLine($"{type.Key}::({GetAverageDamage(type):f2}/{GetAverageHealth(type):f2}/{GetAverageArmor(type):f2})");

                foreach (var dragon in type.Value.OrderBy(dragon => dragon.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }
        private static double GetAverageDamage(KeyValuePair<string, List<Dragon>> type)
                     => type.Value.Sum(dragon => dragon.Damage) * 1.0 / type.Value.Count;
        private static double GetAverageHealth(KeyValuePair<string, List<Dragon>> type)
                     => type.Value.Sum(dragon => dragon.Health) * 1.0 / type.Value.Count;
        private static double GetAverageArmor(KeyValuePair<string, List<Dragon>> type)
            => type.Value.Sum(dragon => dragon.Armor) * 1.0 / type.Value.Count;


        class Dragon
        {
            public Dragon(string name, string damage, string health, string armor)
            {
                this.Name = name;
                this.Damage = damage != "null" ? int.Parse(damage) : 45;
                this.Health = health != "null" ? int.Parse(health) : 250;
                this.Armor = armor != "null" ? int.Parse(armor) : 10;
            }

            public string Name { get; set; }
            public int Damage { get; set; }
            public int Health { get; set; }
            public int Armor { get; set; }
        }
    }
}
