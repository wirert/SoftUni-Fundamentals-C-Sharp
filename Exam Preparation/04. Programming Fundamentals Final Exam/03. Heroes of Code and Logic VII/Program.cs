using System;
using System.Collections.Generic;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numHeroes = int.Parse(Console.ReadLine());

            var listHeroes = new Dictionary<string, Hero>();

            PutHeroesInCollection(numHeroes, listHeroes);

            string inputCommand = null;

            while ((inputCommand = Console.ReadLine()) != "End")
            {
                string[] command = inputCommand.Split(" - ");

                ExecuteCurrentCommand(command, listHeroes);
            }

            foreach (var hero in listHeroes)
            {
                Console.WriteLine(hero.Value);
            }
        }

        private static void PutHeroesInCollection(int numHeroes, Dictionary<string, Hero> listHeroes)
        {
            for (int i = 0; i < numHeroes; i++)
            {
                string[] heroInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Hero hero = new Hero(heroInfo[0], int.Parse(heroInfo[1]), int.Parse(heroInfo[2]));

                if (hero.HitPoints > 100)
                    hero.HitPoints = 100;

                if (hero.ManaPoints > 200)
                    hero.ManaPoints = 200;

                listHeroes.Add(hero.Name, hero);
            }
        }

        private static void ExecuteCurrentCommand(string[] command, Dictionary<string, Hero> listHeroes)
        {
            switch (command[0])
            {
                case "CastSpell":

                    CastSpell(command, listHeroes);
                    break;

                case "TakeDamage":

                    TakeDamage(command, listHeroes);
                    break;

                case "Recharge":

                    RechargeManaPoints(command, listHeroes);
                    break;

                case "Heal":

                    HealHero(command, listHeroes);
                    break;
            }
        }

        private static void CastSpell(string[] command, Dictionary<string, Hero> listHeroes)
        {
            string name = command[1];
            int neededMP = int.Parse(command[2]);
            string spell = command[3];

            if (listHeroes[name].ManaPoints >= neededMP)
            {
                listHeroes[name].ManaPoints -= neededMP;
                Console.WriteLine($"{name} has successfully cast {spell} and now has {listHeroes[name].ManaPoints} MP!");
            }
            else
            {
                Console.WriteLine($"{name} does not have enough MP to cast {spell}!");
            }
        }

        private static void TakeDamage(string[] command, Dictionary<string, Hero> listHeroes)
        {
            string name = command[1];
            int damage = int.Parse(command[2]);
            string attacker = command[3];

            if (listHeroes[name].HitPoints > damage)
            {
                listHeroes[name].HitPoints -= damage;
                Console.WriteLine(
                    $"{name} was hit for {damage} HP by {attacker} and now has {listHeroes[name].HitPoints} HP left!");
            }
            else
            {
                Console.WriteLine($"{name} has been killed by {attacker}!");
                listHeroes.Remove(name);
            }
        }

        private static void RechargeManaPoints(string[] command, Dictionary<string, Hero> listHeroes)
        {
            string name = command[1];
            int amountMP = int.Parse(command[2]);

            if (listHeroes[name].ManaPoints + amountMP > 200)
            {
                amountMP = 200 - listHeroes[name].ManaPoints;
                listHeroes[name].ManaPoints = 200;
            }
            else
            {
                listHeroes[name].ManaPoints += amountMP;
            }

            Console.WriteLine($"{name} recharged for {amountMP} MP!");
        }

        private static void HealHero(string[] command, Dictionary<string, Hero> listHeroes)
        {
            string name = command[1];
            int amountHP = int.Parse(command[2]);

            if (listHeroes[name].HitPoints + amountHP > 100)
            {
                amountHP = 100 - listHeroes[name].HitPoints;
                listHeroes[name].HitPoints = 100;
            }
            else
            {
                listHeroes[name].HitPoints += amountHP;
            }

            Console.WriteLine($"{name} healed for {amountHP} HP!");
        }
    }

    class Hero
    {
        public Hero(string name, int hitPoints, int manaPoints)
        {
            Name = name;
            HitPoints = hitPoints;
            ManaPoints = manaPoints;
        }

        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int ManaPoints { get; set; }

        public override string ToString()
        {
            return $"{Name}\n  HP: {HitPoints}\n  MP: {ManaPoints}";
        }
    }
}
