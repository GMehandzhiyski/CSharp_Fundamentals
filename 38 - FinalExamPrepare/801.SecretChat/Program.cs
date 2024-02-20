using System;

namespace _801.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputMessage = Console.ReadLine();

            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "Reveal")
            {
                string[] commands = arguments
                    .Split(":|:",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = commands[0];
                if (command == "InsertSpace")
                {
                    int index = int.Parse(commands[1]);
                    bool isValidIndex = CheckIndex(inputMessage, index);
                    if (isValidIndex) 
                    {
                        inputMessage = inputMessage.Insert(index," ");
                    }

                }
                else if (command == "Reverse")
                { 
                    string subString = commands[1];
                    bool isHaveOldString = CheckString(inputMessage, subString);
                    if (isHaveOldString)
                    {
                        string temporaryString = ReverseString(subString);
                        inputMessage = inputMessage.Replace(subString,temporaryString);
                    }
                    else
                    {
                        Console.WriteLine("error");
                        continue;
                    }

                }
                else if (command == "ChangeAll")
                {
                    string oldString = commands[1];
                    string newString = commands[2];
                    bool isHaveOldString = CheckString(inputMessage,oldString);
                    if (isHaveOldString) 
                    {
                        inputMessage = inputMessage.Replace(oldString, newString);
                    }
                }
                Console.WriteLine(inputMessage);
            }

            Console.WriteLine($"You have a new text message: {inputMessage}");
        }

        private static string ReverseString(string subString)
        {
            string temporaryString = string.Empty;
            foreach (var currSubstring in subString)
            {
                char tempChar = currSubstring;
                subString = subString.Remove(0, 1);
                temporaryString = tempChar + temporaryString;

            }
            
            return temporaryString;
        }

        private static bool CheckString(string inputMessage, string oldString)
        {
            return inputMessage.Contains(oldString);
        }

        private static bool CheckIndex(string inputMessage, int index)
        {
            return (index >= 0) && (index <= inputMessage.Length - 1);
        }
    }
}