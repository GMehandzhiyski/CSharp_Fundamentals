namespace _1001.ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string argumets = string.Empty;
            while ((argumets = Console.ReadLine()) != "Generate")
            {
                string[] commands = argumets
                    .Split(">>>",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = commands[0];
                if (command == "Contains")
                {
                    string subString = commands[1];
                    bool isFoundSubString =  ContainsString(activationKey, subString);
                    if (isFoundSubString)
                    {
                        Console.WriteLine($"{activationKey} contains {subString}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                        continue;
                    }
                }
                else if (command == "Flip")
                { 
                    string caseChar = commands[1];
                    int startIndex = int.Parse(commands[2]);
                    int endIndex = int.Parse(commands[3]);
                    bool isIndexIsValid = CheckValidIndex(activationKey, startIndex, endIndex);
                    if (!isIndexIsValid)
                    {
                        continue;
                    }
                    if (caseChar == "Upper")
                    {
                        char[] tempCharArray = activationKey.ToCharArray();
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            tempCharArray[i] = char.ToUpper(tempCharArray[i]);
                        }
                        activationKey = new string(tempCharArray);
                    }
                    else if (caseChar == "Lower")
                    {
                        char[] tempCharArray = activationKey.ToCharArray();
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            tempCharArray[i] = char.ToLower(tempCharArray[i]);
                        }
                        activationKey = new string(tempCharArray);
                    }
                   

                }
                else if (command == "Slice")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    bool isIndexIsValid = CheckValidIndex(activationKey, startIndex, endIndex);
                    if (isIndexIsValid) 
                    {
                        activationKey = DeleteChars(activationKey, startIndex, endIndex);
                    }

                }
                Console.WriteLine(activationKey);
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }

        private static bool ContainsString(string activatioKey, string subString)
        {
           return activatioKey.Contains(subString);
        }

        private static string DeleteChars(string activatioKey, int startIndex, int endIndex)
        {
            int countIndex = (endIndex - startIndex);
           return activatioKey.Remove(startIndex,countIndex );
        }

        private static bool CheckValidIndex(string activatioKey, int startIndex, int endIndex)
        {
            return startIndex >= 0 && endIndex <= activatioKey.Length - 1;
        }
    }
}