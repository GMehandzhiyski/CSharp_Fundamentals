namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputString = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            foreach (var userName in inputString)
            {

                bool isUserNameRightLenght = CheckUserNameLenght(userName);
                bool isUserNameCorrect = CheckUserName(userName);
                if (isUserNameRightLenght
                    && isUserNameCorrect)
                {
                    PrintCorrectUserName(userName);
                }
            }
        }

        private static void PrintCorrectUserName(string userName)
        {
            Console.WriteLine(userName);
        }

        private static bool CheckUserNameLenght(string userName)
        {
            return (userName.Length >= 3) && (userName.Length <= 16);
        }

        private static bool CheckUserName(string userName)
        {
            return  userName.All(u => char.IsLetterOrDigit(u) || u == '-' || u == '_');
        }
    }
}