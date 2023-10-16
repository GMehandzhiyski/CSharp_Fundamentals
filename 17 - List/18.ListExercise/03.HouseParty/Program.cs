namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandsNumber = int.Parse(Console.ReadLine());
            List <string> gests = new List<string>();

            for (int i = 0; i < commandsNumber; i++)
            { 
                List <string> commands = Console.ReadLine()
                      .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                      .ToList();
                
                if 
                string middleString0 = commands[0];
                string middleString1 = commands[1];







                // Console.WriteLine(string.Join(" ",commands));    

            }

        }
    }
}