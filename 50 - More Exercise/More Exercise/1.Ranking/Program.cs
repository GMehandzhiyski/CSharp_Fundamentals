using System.ComponentModel;

namespace _1.Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
          
            Dictionary<string, string > rankingDB = new Dictionary<string, string>();
            List<User> users = new List<User>();    

            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "end of contests") 
            {
                string[] argument = arguments
                    .Split(":",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string contests = argument[0];
                string passContest  = argument[1];
                rankingDB.Add(contests, passContest);
            }
            
            while ((arguments = Console.ReadLine()) != "end of submissions")
            {
                string[] argument = arguments
                    .Split("=>",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string contests = argument[0];
                string pass = argument[1];
                string name = argument[2];
                int points = int.Parse(argument[3]);

                bool isContestIsValid = CheckValidContest(rankingDB, contests);
                bool isPassIsValid = CheckValidPass(rankingDB, pass);
                if (isContestIsValid
                    && isPassIsValid)
                {
                    User user = new User(contests, pass, name, points);
                    bool isUserIsNew = CheckForUserAndContent(users, contests,name);
                    if (isUserIsNew)
                    {
                        users.Add(user);
                    }
                    else 
                    {
                        updateUserInfo(users, contests, name, points);
                    }
                }
                else
                {
                    Console.WriteLine("notValid");
                }

            }

            PrintBestCandidate(users);



        }

        private static void PrintBestCandidate(List<User> users)
        {
            
            //foreach (User user in users) 
            //{
            //    int totalPoint = 0;
            //    foreach (User curr in user.Name)
            //    {
            //        totalPoint += curr.Points;
            //    }
            //}
           
        }

        private static void updateUserInfo(List<User> users, string contests, string name, int points)
        {
            User currUser = users.Where(u => u.Name == name).FirstOrDefault();


            if (currUser.Points < points)
            {

                currUser.Points = points;
            }
            

        }

        private static bool CheckForUserAndContent(List<User> users, string contests,string name)
        {
            bool isUserIsNew = true;
            User currUser = users.Where(u => u.Name == name).FirstOrDefault();
            User currContest = users.Where(u => u.Contests == contests).FirstOrDefault();
            if (currUser != null
               && currContest != null) 
            {
                return isUserIsNew = false;
            }
            return isUserIsNew;
        }

        private static bool CheckValidPass(Dictionary<string, string> rankingDB, string pass)
        {
            bool isContestIsPass = false;

            foreach (var currPass in rankingDB)
            {
                if (currPass.Value == pass)
                {
                    return isContestIsPass = true;

                }
            }

            return isContestIsPass;
        }

        private static bool CheckValidContest(Dictionary<string, string> rankingDB, string contests)
        {
           bool isContestIsValid = false;

            foreach (var currContests in rankingDB)
            {
                if (currContests.Key == contests)
                { 
                   return isContestIsValid = true;
                    
                }
            }

            return isContestIsValid;
        }
    }
    public class User
    {
        public User(string contests, string pass, string name, int points)
        {
            Name = name;
            Contests = contests;
            Pass = pass;
            Points = points;
        }

        public string Name { get; set; }
        public string Contests { get; set; }

        public string Pass { get; set; }
        public int Points { get; set; } 
    }

}