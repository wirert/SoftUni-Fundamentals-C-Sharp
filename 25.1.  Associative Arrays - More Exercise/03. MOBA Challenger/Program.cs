using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBA_Challenger
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var players = new Dictionary<string, Dictionary<string, int>>();

            string command = null;

            while ((command = Console.ReadLine()) != "Season end")
            {
                if (command.Contains("->"))
                {
                    AddOrUpdatePlayer(command, players);
                }
                else
                {
                    DuelBetweenTwoPlayers(command, players);
                }
            }

            PrintPlayersDescendingBySkill(players);
        }

        private static void PrintPlayersDescendingBySkill(Dictionary<string, Dictionary<string, int>> players)
        {
            var orderedPlayers = players.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key).ToList();

            foreach (var player in orderedPlayers)
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

                foreach (var position in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }

        private static void DuelBetweenTwoPlayers(string command, Dictionary<string, Dictionary<string, int>> players)
        {
            string[] duel = command.Split(" vs ");
            string firstPlayer = duel[0];
            string secondPlayer = duel[1];

            if (!players.ContainsKey(firstPlayer) || !players.ContainsKey(secondPlayer)) return;
            string concurPosition = null;
            foreach (var position in players[firstPlayer]
                         .Where(positions => players[secondPlayer]
                             .ContainsKey(positions.Key)))
            {
                concurPosition = position.Key;
            }

            if (concurPosition == null) return;

            if (players[firstPlayer].Values.Sum() == players[secondPlayer].Values.Sum()) return;

            players.Remove(players[firstPlayer].Values.Sum() > players[secondPlayer].Values.Sum()
                ? secondPlayer
                : firstPlayer);
        }

        private static void AddOrUpdatePlayer(string command, Dictionary<string, Dictionary<string, int>> players)
        {
            string[] playerInfo = command.Split(" -> ");
            string player = playerInfo[0];
            string position = playerInfo[1];
            int skill = int.Parse(playerInfo[2]);

            if (!players.ContainsKey(player))
            {
                players.Add(player, new Dictionary<string, int>()
                {
                    {position, skill}
                });
            }
            else
            {
                if (!players[player].ContainsKey(position))
                {
                    players[player].Add(position, skill);
                }
                else
                {
                    if (players[player][position] < skill)
                    {
                        players[player][position] = skill;
                    }
                }
            }
        }
    }
}
