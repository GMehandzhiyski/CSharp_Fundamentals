using System.Text;

namespace _205.TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < numberOfTeams; i++)
            {
                string[] arduments = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string creator = arduments[0];
                string teamName = arduments[1];


                Team team = new Team(creator, teamName);


                bool isTeamIsCreated = CheckTeamInList(teams,teamName);
                bool isCreatorIsHaveTeam = CheckCreatorIsHaveTeam(teams,creator);

                if (isTeamIsCreated)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (isCreatorIsHaveTeam)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else if(!isTeamIsCreated
                    && !isCreatorIsHaveTeam)
                {
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "end of assignment")
            {
                string[] argument = arguments 
                    .Split("->",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string userName = argument[0];
                string teamName = argument[1];

                bool isTeamIsAvalivable = CheckTeamInList(teams, teamName);
                bool isUserIsInAnotherTeam = CheckUser(teams, userName);

                if (!isTeamIsAvalivable)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (isUserIsInAnotherTeam)
                {
                    Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                }
                else if(isTeamIsAvalivable
                    && !isUserIsInAnotherTeam)
                {
                    bool isAddtoUserList = false;
                    foreach (Team currTeam in teams)
                    {
                        if (currTeam.TeamName == teamName
                            && currTeam.Creator != userName)
                        {
                            currTeam.UserName.Add(userName);
                            isAddtoUserList = true;
                            break;
                        }
                    }
                    if (!isAddtoUserList)
                    {
                        Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                    }
                }

            }

            
            PrintValidResult(teams);
            DisbandTeam(teams);
        }

        private static void PrintValidResult(List<Team> teams)
        {
            foreach (var currTeam in teams.OrderByDescending(t => t.TeamName))
            {
                if (currTeam.UserName.Count > 0) 
                {

                    Console.WriteLine($"{currTeam.TeamName}\n- {currTeam.Creator}");
                    foreach (var currUserName in currTeam.UserName)
                    {
                        Console.WriteLine($"-- {currUserName}");
                    }
                }
                
            }
        }

        private static void DisbandTeam(List<Team> teams)
        {
            Console.WriteLine($"Teams to disband:");
            foreach (var currTeam in teams)
            {
                if (currTeam.UserName.Count <= 0)
                {
                    Console.WriteLine($"{ currTeam.TeamName}");
                }
            }
        }

        public static bool CheckUser(List<Team> teams, string userName)
        {
            bool isUserIsInAnotherTeam = false;


            foreach (var currTeam in teams)
            {
                foreach (var currUserName in currTeam.UserName)
                {
                    if (currUserName == userName)
                    {
                       isUserIsInAnotherTeam = true;
                    }
                  
                }
            }
            return isUserIsInAnotherTeam;
        }

        public static bool CheckCreatorIsHaveTeam(List<Team> teams, string creator)
        {
           bool isCreatorIsHaveTeam = false;
           Team currCreator = teams.Where(t => t.Creator == creator).FirstOrDefault();
            if (currCreator != null) 
            {
               return isCreatorIsHaveTeam = true;
            }
            return isCreatorIsHaveTeam;
        }

        private static bool CheckTeamInList(List<Team> teams, string teamName)
        {
            bool isTeamIsCreated = false;
           Team currTeam = teams.Where(t => t.TeamName == teamName).FirstOrDefault();
            if (currTeam != null) 
            {
                return isTeamIsCreated = true;
            }
            return isTeamIsCreated;
        }
    }
    public class Team
    {
        public Team(string creator, string teamName)
        {
            Creator = creator;
            TeamName = teamName; 
            UserName = new List<string>();
        }

        public string Creator { get; set; }
        public string TeamName { get; set; }
        public List<string> UserName { get; set; }

    }
}