using Microsoft.VisualBasic;

namespace _901.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string argumets = string.Empty;
            while ((argumets = Console.ReadLine()) != "Done")
            {
                string[] commands = argumets
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = commands[0];

                if (command == "TakeOdd")
                {
                    password = TakeOddChar(password);
                }
                else if (command == "Cut")
                {
                    int index = int.Parse(commands[1]);
                    int lenght = int.Parse(commands[2]);

                    bool isValidIndexAndLength = CheckIndex(password, index, lenght);
                    if (isValidIndexAndLength)
                    {
                        password = CutString(password, index, lenght);
                    }
                }
                else if (command == "Substitute")
                {
                    string oldString = commands[1];
                    string newString = commands[2];

                    bool isHaveValidSubString = ChekSubString(password, oldString);
                    if (isHaveValidSubString)
                    {
                        password = SubstituteString(password, oldString, newString);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
                else
                {
                    continue;
                }

                Console.WriteLine(password);
            }
            PrintFinalResult(password);

        }

        private static void PrintFinalResult(string password)
        {
            Console.WriteLine($"Your password is: {password}");
        }

        private static string SubstituteString(string password, string oldString, string newString)
        {
            return password.Replace(oldString, newString);
        }

        private static bool ChekSubString(string password, string oldString)
        {
            return password.Contains(oldString);
        }

        private static string CutString(string password, int index, int lenght)
        {
            return password = password.Remove(index, lenght);
        }

        private static bool CheckIndex(string password, int index, int lenght)
        {

            return (index >= 0 && index < password.Length - 1) && (((password.Length - 1) - index) >= lenght);   
        }

        private static string TakeOddChar(string password)
        {
            string OddPassword = string.Empty;
            for (int i = 0; i < password.Length; i++)
            {
                if (i % 2 != 0)
                {
                    OddPassword = OddPassword + password[i];
                }
            }

            return OddPassword;
        }
    }
}