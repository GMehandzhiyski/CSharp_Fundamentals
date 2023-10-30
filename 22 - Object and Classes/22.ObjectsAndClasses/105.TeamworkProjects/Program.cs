namespace _105.TeamworkProjects
{      // ICOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
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
                string teamName = arguments[0];
                string creator = arguments[1];
                string member = arguments[2];

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
                    Team team = new Team(teamName, creator, member);
                    teamList.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }

            }
            string argumets;
            while ((argumets = Console.ReadLine()) != "end of assignment")
            {
                List<string> inputMembersList = Console.ReadLine()
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


        }

        private static bool CheckMemberJoin(string nameMember, List<Team> teamList)
        {
            bool isMemberNotJoin = false;

            //foreach (Team MemberName in teamList)
            //{
            //    if (MemberName.Members == nameMember)
            //    {
            //        isMemberNotJoin = true;
            //    }
            //}

           //Team isMemberNotJoinTeams = teamList.Find(t => t.Members = nameMember);
           // if (isMemberNotJoinTeams != null)
           // {
           //     isMemberNotJoin = true;
           // }
            return isMemberNotJoin;
        }

        private static bool CheckExistTeam(string team, List<Team> teamList)
        {
            bool isTeamNotExist = true;
            foreach (Team teamName in teamList)
            {
                if (teamName.TeamName == team)
                {
                    isTeamNotExist = false;
                }

            }
            return isTeamNotExist;
        }

        private static bool CheckHaveCreator(string creator, List<Team> teamList)
        {
            bool isHaveCreator = false;
            foreach (Team creatorName in teamList)
            {
                if (creatorName.Creator == creator)
                {
                    isHaveCreator = true;
                }
            }
            return isHaveCreator;
        }

        private static bool CheckHaveTeam(string teamName, List<Team> teamList)
        {
            bool isFoundTeam = false;
            foreach (Team teamNam in teamList)
            {
                if (teamNam.TeamName == teamName)
                {
                    isFoundTeam = true;
                }
            }
            return isFoundTeam;
        }
    }
    class Team
    {
        public Team(string teamName, string creator, string member)
        {
            TeamName = teamName;
            Creator = creator;
            Members = new List<string>();
        }

        public string TeamName { get; set; }

        public string Creator { get; set; }

        public new List<string> Members { get; set; }
    }
}