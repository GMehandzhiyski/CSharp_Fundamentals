namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandsNumber = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();

            for (int i = 0; i < commandsNumber; i++)
            { 
                List <string> commands = Console.ReadLine()
                      .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                      .ToList();
                
                string middleString0 = commands[0];
                string middleString1 = commands[1];
                string middleString2 = commands[2];

                if (middleString1 == "is" && middleString2 != "not")
                {
                    if (names.Contains(middleString0))
                    {
                        Console.WriteLine($"{middleString0} is already in the list!");
                    }
                    else 
                    {
                        names.Add(middleString0);
                    }
                    

                }
                else if (middleString2 == "not")
                {
                    if (names.Contains(middleString0))
                    {
                        names.RemoveAll(x => x == middleString0);
                    }
                    else
                    {
                        Console.WriteLine($"{middleString0} is not in the list!");
                    }
                    
                }
                else 
                {
                    continue;
                }

            }

            foreach (var item in names)
            {
                Console.WriteLine(item); 
            }
               
        }
    }
}