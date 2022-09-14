using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teamCount = int.Parse(Console.ReadLine());

            List<Teams> teams = new List<Teams>();

            for (int i = 0; i < teamCount; i++)
            {
                string[] curTeam = Console.ReadLine().Split('-');

                Teams team = new Teams(curTeam[1], curTeam[0], new List<string>());

                if (teams.Any(x => x.Name == team.Name))
                    Console.WriteLine($"Team {team.Name} was already created!");

                else if (teams.Any(x => x.Creator == team.Creator))
                    Console.WriteLine($"{team.Creator} cannot create another team!");

                else
                {
                    teams.Add(team);
                    Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
                }
            }

            string command = Console.ReadLine();

            while (command != "end of assignment")
            {
                string[] memberTeamInfo = command.Split("->");
                string memberName = memberTeamInfo[0];
                string teamName = memberTeamInfo[1];

                if (!teams.Exists(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Any(tim => tim.Members.Contains(memberName))
                    || teams.Any(x => x.Creator == memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                }
                else
                {
                    teams.Find(x => x.Name == teamName).Members.Add(memberName);
                }

                command = Console.ReadLine();
            }

            var teamsToPlay = teams
                .Where(team => team.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count).ThenBy(y => y.Name).ToList();

            foreach (var team in teamsToPlay)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            var teamsToDisband = teams
                .Where(team => team.Members.Count == 0)
                .OrderBy(team => team.Name).ToList();

            foreach (var team in teamsToDisband)
            {
                Console.WriteLine(team.Name);
            }
        }
    }

    class Teams
    {
        public Teams(string name, string creator, List<string> members)
        {
            this.Name = name;
            this.Creator = creator;
            this.Members = members;
        }

        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
}
