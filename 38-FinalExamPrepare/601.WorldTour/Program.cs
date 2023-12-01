namespace _601.WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputStops = Console.ReadLine();

            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "Travel")
            {
                string[] commands = arguments
                    .Split(":", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = commands[0];
                if (command == "Add Stop")
                {
                    int index = int.Parse(commands[1]);
                    string newString = commands[2];
                    bool isValidIndex = CheckValidIndex(inputStops,index);
                    if (isValidIndex)
                    {
                        inputStops = AddNewString(inputStops, index, newString);
                    }
                    
                }
                else if (command == "Remove Stop")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    if (startIndex >= 0
                        && endIndex <= (inputStops.Length - 1)) 
                    {
                        inputStops = RemoveStop(inputStops, startIndex, endIndex);
                    }
                    
                }
                else if (command == "Switch")
                {
                    string oldString = commands[1];
                    string newString = commands[2];
                    bool isOldstringIsAvalivable = CheckValidString(inputStops, oldString);
                    if (isOldstringIsAvalivable) 
                    {
                        inputStops = SwitchStrings(inputStops, oldString, newString);
                    }
                }
                else
                {
                    continue;
                }

                Console.WriteLine(inputStops);
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {inputStops}");
        }

        private static string SwitchStrings(string inputStops, string oldString, string newString)
        {
            return inputStops.Replace(oldString,newString);
        }

        private static bool CheckValidString(string inputStops, string oldString)
        {
          return inputStops.Contains(oldString);
        }

        private static bool CheckValidIndex(string inputStops, int index)
        {
            return index >= 0 && index <= inputStops.Length - 1; 
        }

        private static string RemoveStop(string inputStops, int startIndex, int endIndex)
        { 
            return inputStops.Remove(startIndex, ((endIndex - startIndex) + 1));
        }

        public static string AddNewString(string inputStops, int index, string newString)
        {
            return inputStops.Insert(index, newString);
        }
    }
}