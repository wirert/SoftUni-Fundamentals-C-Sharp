using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _02._Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contestList = new Dictionary<string, Dictionary<string, int>>();
            var participantsList = new Dictionary<string, Dictionary<string, int>>();

            string[] input = Console.ReadLine().Split(" -> ");

            while (input[0] != "no more time")
            {
                string participant = input[0];
                string contestName = input[1];
                int points = int.Parse(input[2]);

                AddContestInListOfContests(contestList, participant, contestName, points);

                AddParticipantInListOfParticipants(participantsList, participant, contestName, points);

                input = Console.ReadLine().Split(" -> ");
            }

            PrintOrderedContestByPoints(contestList);

            PrintParticipantsStatistics(participantsList);
        }

        private static void AddContestInListOfContests(Dictionary<string, Dictionary<string, int>> contestList, string participant, string contestName, int points)
        {
            if (!contestList.ContainsKey(contestName))
            {
                contestList.Add(contestName, new Dictionary<string, int>
                {
                    {participant, points}
                });
            }
            else
            {
                if (!contestList[contestName].ContainsKey(participant))
                {
                    contestList[contestName].Add(participant, points);
                }
                else
                {
                    if (contestList[contestName][participant] < points)
                        contestList[contestName][participant] = points;
                }
            }
        }

        private static void AddParticipantInListOfParticipants(Dictionary<string, Dictionary<string, int>> participantsList, string participant, string contestName, int points)
        {
            if (!participantsList.ContainsKey(participant))
            {
                participantsList.Add(participant, new Dictionary<string, int>
                {
                    {contestName, points}
                });
            }
            else
            {
                if (!participantsList[participant].ContainsKey(contestName))
                {
                    participantsList[participant].Add(contestName, points);
                }
                else
                {
                    if (participantsList[participant][contestName] < points)
                        participantsList[participant][contestName] = points;
                }
            }
        }

        private static void PrintOrderedContestByPoints(Dictionary<string, Dictionary<string, int>> contestList)
        {
            foreach (var contest in contestList)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");

                var orderedParticipants = contest.Value.OrderByDescending(p => p.Value).ThenBy(p => p.Key).ToList();
                int count = 0;
                foreach (var participant in orderedParticipants)
                {
                    count++;
                    Console.WriteLine($"{count}. {participant.Key} <::> {participant.Value}");
                }
            }
        }

        private static void PrintParticipantsStatistics(Dictionary<string, Dictionary<string, int>> participantsList)
        {
            Console.WriteLine("Individual standings:");

            var orderedList = participantsList.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(z => z.Key).ToList();

            int count = 0;
            foreach (var participant in orderedList)
            {
                count++;
                Console.WriteLine($"{count}. {participant.Key} -> {participant.Value.Values.Sum()}");
            }
        }
    }
}
