namespace _02.TreasureHunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string arguments;
            while ((arguments = Console.ReadLine()) != "Yohoho!")
            {
                string[] commands = arguments.Split();

                if (commands[0] == "Loot")
                {
                    for (int i = 1; i < commands.Length; i++)
                    {
                        string treashureCommands = commands[i];
                        int isFoundTreashure = inputList.IndexOf(treashureCommands);
                        if (isFoundTreashure == -1)
                        { 
                            inputList.Insert(0, treashureCommands);
                        }

                    }

                }
                else if (commands[0] == "Drop")
                {
                    int index = int.Parse(commands[1]);
                    if (0 >= index && index <= inputList.Count)
                    { 
                        string saveValue = inputList[index];
                        inputList.RemoveAt(index);
                        inputList.Add(saveValue);
                    
                    }

                }
                else if (commands[0] == "Steal")
                {
                    string printTreashure = string.Empty;
                    int count = int.Parse(commands[1]); 
                    for (int i = inputList.Count - 1 ; i >= count; i--)
                    {
                        string saveValue = inputList[i];

                        printTreashure += saveValue + ", ";


                    }
                    
                    Console.WriteLine(printTreashure);  

                }

            }
            int countLetter = 0;
            for (int i = 0; i < inputList.Count; i++) 
            {

                foreach (var item in inputList[i])
                {
                    countLetter++;
                }

            }

            if (countLetter == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                Console.WriteLine($"Average treasure gain: {countLetter / inputList.Count:f2} pirate credits.");
            }
            

        }
    }
}