namespace Problem_1
{
    /*
    ILikeSoftUni
    Replace I We
    Make Upper
    Check SoftUni
    Sum 1 4
    Cut 1 4
    Finish

HappyNameDay
Replace p r
Make Lower
Cut 2 23
Sum -2 2
Finis
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string arguments = String.Empty;
            while ((arguments = Console.ReadLine()) != "Finish")
            {
                string[] commands = arguments
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = commands[0];

                if (command == "Replace")
                {
                    string currentChar = commands[1];
                    string newChar = commands[2];
                    //bool isStringIsAvalivable = CheckString(message, currentChar, newChar);
                    message = ReplaceChar(message, currentChar, newChar);
                    PrintMessage(message);


                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    bool isValidIndex = CheckIndex(message, startIndex, endIndex);
                    if (isValidIndex)
                    {
                        message = RemoveString(message, startIndex, endIndex);
                        PrintMessage(message);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }

                }
                else if (command == "Make")
                {
                    string upperLower = commands[1];
                    if (upperLower == "Upper")
                    {
                        char[] tempCharArray = message.ToCharArray();

                        for (int i = 0; i < message.Length; i++)
                        {
                            tempCharArray[i] = char.ToUpper(tempCharArray[i]);
                        }

                        message = new string(tempCharArray);
                        PrintMessage(message);
                    }
                    else if (upperLower == "Lower")
                    {
                        char[] tempCharArray = message.ToCharArray();

                        for (int i = 0; i < message.Length; i++)
                        {
                            tempCharArray[i] = char.ToLower(tempCharArray[i]);
                        }

                        message = new string(tempCharArray);
                        PrintMessage(message);
                    }

                }
                else if (command == "Check")
                {
                    string stringCheck = commands[1];
                    bool isStringIsAvalivable = CheckString(message, stringCheck);
                    if (isStringIsAvalivable)
                    {
                        Console.WriteLine($"Message contains {stringCheck}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {stringCheck}");
                    }

                }
                else if (command == "Sum")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    bool isValidIndex = CheckIndex(message, startIndex, endIndex);
                    if (isValidIndex)
                    {
                        string tempSubString = String.Empty;
                        tempSubString = SubString(message, startIndex, endIndex);
                        int sumOfChar = 0;
                        foreach (var currChar in tempSubString)
                        {
                            sumOfChar = sumOfChar + currChar;
                        }
                        Console.WriteLine(sumOfChar);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                }
            }
        }

        private static string RemoveString(string message, int startIndex, int endIndex)
        {
            int coutSub = (endIndex - startIndex) + 1;
            return message.Remove(startIndex, coutSub);
        }

        private static string SubString(string message, int startIndex, int endIndex)
        {
            int coutSub = (endIndex - startIndex) + 1;
            return message.Substring(startIndex, coutSub);
        }

        private static bool CheckIndex(string message, int startIndex, int endIndex)
        {
            return (startIndex >= 0 && startIndex < message.Length) && (endIndex < message.Length && endIndex >= 0) ;
        }

        private static bool CheckString(string message, string stringCheck)
        {
            return message.Contains(stringCheck);
        }

        private static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        private static string ReplaceChar(string message, string currentChar, string newChar)
        {
            return message.Replace(currentChar, newChar);
        }
    }
}