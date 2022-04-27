using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputCreate = Console.ReadLine().Split('-');

                string creator = inputCreate[0];
                string teamName = inputCreate[1];

                if(teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if(teams.Any(t => t.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team team = new Team(teamName, creator);
                teams.Add(team);

                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            string input;

            while((input = Console.ReadLine()) != "end of assignment")
            {
                string[] command = input.Split("->");

                string user = command[0];
                string team = command[1];

                if(!teams.Any(t => t.Name == team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                    continue;
                }

                if(teams.Any(t => t.Users.Contains(user)) || teams.Any(t => t.Creator == user))
                {
                    Console.WriteLine($"Member {user} cannot join team {team}!");
                    continue;
                }

                teams.Find(t => t.Name == team).Users.Add(user);
            }

            foreach (Team team in teams.Where(t => t.Users.Count > 0).OrderByDescending(t => t.Users.Count).ThenBy(t => t.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");

                team.Users.Sort();

                foreach (string user in team.Users)
                {
                    Console.WriteLine($"-- {user}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (Team team in teams.Where(t => t.Users.Count == 0).OrderBy(t => t.Name))
            {
                Console.WriteLine(team.Name);
            }
        }
    }

    public class Team
    {
        public Team(string name, string creator)
        {
            this.Name = name;
            this.Creator = creator;
            this.Users = new List<string>();
        }
        public string Name { get; set; }
        public String Creator { get; set; }
        public List<string> Users { get; set; }
    }
}
