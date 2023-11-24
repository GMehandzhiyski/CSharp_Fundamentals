using System.Reflection.Metadata.Ecma335;

namespace _501.ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string activationKey = Console.ReadLine();

            string argumnets = string.Empty;
            while ((argumnets = Console.ReadLine()) != "Generate")
            {
                string[] commands = argumnets
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = commands[0];

                if (command == "Contains")
                {
                    string subString = commands[1];

                    bool isHaveSubString = activationKey.Contains(subString);

                    if (isHaveSubString)
                    {
                        Console.WriteLine($"{activationKey} contains {subString}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                else if (command == "Flip")
                {
                    string cases = commands[1];
                    int startIndex = int.Parse(commands[2]);
                    int endIndex = int.Parse(commands[3]);

                    if (cases == "Upper")
                    {
                        char[] tempCharArray = activationKey.ToCharArray();

                        for (int i = startIndex; i < endIndex; i++)
                        {
                            tempCharArray[i] = char.ToUpper(tempCharArray[i]);
                        }

                        activationKey = new string(tempCharArray);
                        PrintFinalResult(activationKey);

                    }

                    if (cases == "Lower")
                    {
                        char[] tempCharArray = activationKey.ToCharArray();

                        for (int i = startIndex; i < endIndex; i++)
                        {
                            tempCharArray[i] = char.ToLower(tempCharArray[i]);
                        }

                        activationKey = new string(tempCharArray);
                        PrintFinalResult(activationKey);
                    }

                }
                else if (command == "Slice")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    activationKey = activationKey.Remove(startIndex,endIndex - startIndex);
                    PrintFinalResult(activationKey);
                }
                else
                {
                    continue;
                }
             
               
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }

        private static void PrintFinalResult(string? activationKey)
        {
            Console.WriteLine(activationKey);
        }
    }
}