namespace _401.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string inputString = Console.ReadLine();
            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "Done" )
            {
                string[] commands = arguments
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = commands[0];

                if (command == "TakeOdd")
                {
                    inputString = TakeOddChar(inputString);
                }
                else if (command == "Cut")
                {
                    int index =int.Parse(commands[1]);
                    int length = int.Parse(commands[2]);

                    inputString = CutStringElements(inputString, index, length);
                }
                else if (command == "Substitute")
                {
                    string OldString = commands[1];
                    string newString = commands[2];

                    bool isFoundOldString = CheckForOldString(inputString, OldString);
                    if (isFoundOldString)
                    {
                        inputString = ReplaceString(inputString, OldString, newString);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                        continue;
                    }
                   
                }
                else
                {
                    continue;
                }

                Console.WriteLine(inputString);
            }

            Console.WriteLine($"Your password is: {inputString}");
        }

        private static bool CheckForOldString(string inputString, string oldString)
        {
           return inputString.Contains(oldString);
        }

        public static string ReplaceString(string inputString, string oldString, string newString)
        {
            return inputString.Replace(oldString, newString);
        }

        public static string CutStringElements(string inputString, int index, int length)
        { 
            return inputString.Remove(index, length);
        }
        public static string TakeOddChar(string inputString)
        {
            string newString = string.Empty;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (i % 2 != 0)
                {
                    newString += inputString[i];
                }
            }

            return newString;
        }
    }
}