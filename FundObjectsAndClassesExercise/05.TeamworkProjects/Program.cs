using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _05.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamsNumber = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamsNumber; i++)
            {
                string[] teamsInfo = Console.ReadLine().Split("-");
                string creator = teamsInfo[0];
                string teamName = teamsInfo[1];

                if (teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teams.Any(x => x.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team team = new Team(teamName, creator);
                teams.Add(team);

                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] userWithTeam = input.Split("->");
                string userToAdd = userWithTeam[0];
                string teamToCheck = userWithTeam[1];

                if (!teams.Any(x => x.TeamName == teamToCheck))
                {
                    Console.WriteLine($"Team {teamToCheck} does not exist!");
                    continue;
                }
                else if (teams.Any(x => x.usersAddedToTeam.Contains(userToAdd)) || 
                    teams.Any(x => x.Creator == userToAdd && x.TeamName == teamToCheck))
                {
                    Console.WriteLine($"Member {userToAdd} cannot join team {teamToCheck}!");
                    continue;
                }
                else
                {
                    int index = teams.FindIndex(x => x.TeamName == teamToCheck);
                    teams[index].usersAddedToTeam.Add(userToAdd);
                }
               
            }

            var teamsToDisband = teams
                .FindAll(x => x.usersAddedToTeam.Count == 0)
                .OrderBy(x => x.TeamName)
                .ToList();
            teams.RemoveAll(x => x.usersAddedToTeam.Count == 0);
            var validTeams = teams
                .OrderByDescending(x => x.usersAddedToTeam.Count)
                .ThenBy(x => x.TeamName)
                .Where(x => x.usersAddedToTeam.Count > 0).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, validTeams.OrderByDescending(x => x.usersAddedToTeam.Count).
                ThenBy(x => x.TeamName)));

            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsToDisband)
            {
                Console.WriteLine(team.TeamName);
            }
            
        }
    }

    public class Team
    {
        public string TeamName { get; set; }
        public string Creator { get; set; }

        public List<string> usersAddedToTeam;

        public Team(string teamName, string creator)
        {
            this.TeamName = teamName;
            this.Creator = creator;
            usersAddedToTeam = new List<string>();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{TeamName}");
            stringBuilder.AppendLine($"- {Creator}");
            foreach (var user in usersAddedToTeam.OrderBy(x => x))
            {
                stringBuilder.AppendLine($"-- {user}");
            }
            
            return stringBuilder.ToString().TrimEnd();
        }
    }
}
