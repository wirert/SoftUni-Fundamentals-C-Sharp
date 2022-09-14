using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    internal class Program
    {
        static void Main()
        {
            string[] inputContest = Console.ReadLine().Split(':');

            List<Contest> contests = new List<Contest>();

            while (inputContest[0] != "end of contests")
            {
                Contest contest = new Contest(inputContest[0], inputContest[1]);
                contests.Add(contest);

                inputContest = Console.ReadLine().Split(':');
            }

            var candidateResults = new SortedDictionary<string, Dictionary<Contest, int>>();

            string[] inputSubmission = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);

            while (inputSubmission[0] != "end of submissions")
            {
                string curContest = inputSubmission[0];
                string passOfContest = inputSubmission[1];
                string user = inputSubmission[2];
                int points = int.Parse(inputSubmission[3]);

                if (!contests.Exists(c => c.Name == curContest && c.Password == passOfContest))
                {
                    inputSubmission = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }

                Contest contest = contests.Find(c => c.Name == curContest && c.Password == passOfContest);

                if (!candidateResults.ContainsKey(user))
                {
                    candidateResults.Add(user, new Dictionary<Contest, int>());
                }

                if (!candidateResults[user].ContainsKey(contest))
                {
                    candidateResults[user].Add(contest, points);
                }
                else
                {
                    if (points > candidateResults[user][contest])
                        candidateResults[user][contest] = points;
                }

                inputSubmission = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
            }

            PrintBestCandidateResult(candidateResults);

            PrintCandidatesResultsSorted(candidateResults);
        }

        private static void PrintBestCandidateResult(SortedDictionary<string, Dictionary<Contest, int>> candidates)
        {
            int bestPoints = 0;
            string bestCandidate = null;

            foreach (var user in candidates.Where(user => user.Value.Values.Sum() > bestPoints))
            {
                bestPoints = user.Value.Values.Sum();
                bestCandidate = user.Key;
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestPoints} points.");
        }

        private static void PrintCandidatesResultsSorted(SortedDictionary<string, Dictionary<Contest, int>> candidateResults)
        {
            Console.WriteLine("Ranking:");

            foreach (var candidate in candidateResults)
            {
                Console.WriteLine(candidate.Key);

                var sortedByPoints = candidate.Value.OrderByDescending(x => x.Value).ToList();

                foreach (var contest in sortedByPoints)
                {
                    Console.WriteLine($"#  {contest.Key.Name} -> {contest.Value}");
                }
            }
        }
    }

    class Contest
    {
        public Contest(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }

        public string Name { get; set; }
        public string Password { get; set; }
    }
}
