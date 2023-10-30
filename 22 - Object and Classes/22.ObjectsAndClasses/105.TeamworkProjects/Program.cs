namespace _105.TeamworkProjects
{      // ICOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO

    /*
0
John-PowerPuffsCoders
Tony-Tony is the best
Peter->PowerPuffsCoders
Tony->Tony is the best
end of assignment
        */
    public class Program
    {
        static void Main(string[] args)
        {
            int countTeams = int.Parse(Console.ReadLine());
            List<Team> teamList = new List<Team>();

            for (int i = 0; i < countTeams; i++)
            {
                string[] arguments = Console.ReadLine()
                     .Split("-", StringSplitOptions.RemoveEmptyEntries)
                     .ToArray();
                string creator = arguments[0];
                string teamName = arguments[1];
                //string member = arguments[2];

                bool isHaveTeam = CheckHaveTeam(teamName, teamList); //return True when have a teamm
                bool isHaveCreator = CheckHaveCreator(creator, teamList); // return TRUE when have a creator

                if (isHaveTeam)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }

                else if (isHaveCreator)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }

                else
                {
                    Team team = new Team(teamName, creator);
                    //team.Members.Add(member);
                    teamList.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }

            }
            string argumets;
            while ((argumets = Console.ReadLine()) != "end of assignment")
            {
                List<string> inputMembersList = argumets
                    .Split("->", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string nameMember = inputMembersList[0];
                string team = inputMembersList[1];

                bool isTeamNotExist = CheckExistTeam(team, teamList);// retunt TRUE when team NOT EXIST
                bool isMemberNotJoin = CheckMemberJoin(nameMember, teamList);// return TRUE  when Merber is in another team

                if (isTeamNotExist)
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                else if (isMemberNotJoin)
                {
                    Console.WriteLine($"Member {nameMember} cannot join team {team}!");
                }
                else
                {

                    foreach (Team teams in teamList)
                    {
                        if (teams.TeamName == team)
                        {
                            teams.Members.Add(nameMember);
                        }

                    }

                }

            }

            PrintTeams(teamList);



        }


        private static void PrintTeams(List<Team> teamList)
        {
            List <string> teamsToDisband = new List<string>();

            foreach (Team currTeam in teamList.OrderByDescending(t => t.TeamName))
            {
                if (currTeam.Members.Count > 0)
                {
                    Console.WriteLine($"{currTeam.TeamName}");
                    Console.WriteLine($"- {currTeam.Creator}");

                    foreach (string currMembers in currTeam.Members)
                    {
                        Console.WriteLine($"-- {currMembers}");
                    }
                }
                else
                {
                  teamsToDisband.Add(currTeam.TeamName);
                }
            }

            Console.WriteLine($"Teams to disband:");

            foreach (string currTeamName in teamsToDisband)
            {
              
                Console.WriteLine($"{currTeamName}");
            }
           

        }

        private static bool CheckMemberJoin(string nameMember, List<Team> teamList)
        {

            foreach (Team currTeam in teamList)
            {
                if (currTeam.Creator != nameMember)
                {
                    foreach (var member in currTeam.Members)
                    {
                        if (member == nameMember)
                        {
                            return true;
                        }
                    }
                }
                else 
                {
                    return true;
                }
                

            }

            return false;
        }

        private static bool CheckExistTeam(string team, List<Team> teamList)
        {

            foreach (Team teamName in teamList)
            {
                if (teamName.TeamName == team)
                {
                    return false;
                }

            }
            return true;
        }

        private static bool CheckHaveCreator(string creator, List<Team> teamList)
        {
            foreach (Team creatorName in teamList)
            {
                if (creatorName.Creator == creator)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool CheckHaveTeam(string teamName, List<Team> teamList)
        {
            foreach (Team teamNam in teamList)
            {
                if (teamNam.TeamName == teamName)
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Team
    {
        public Team(string teamName, string creator)
        {
            TeamName = teamName;
            Creator = creator;
            Members = new List<string>();
        }

        public string TeamName { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }
    }
}