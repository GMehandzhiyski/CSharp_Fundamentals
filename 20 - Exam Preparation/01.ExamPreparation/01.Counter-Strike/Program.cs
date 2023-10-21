namespace _01.Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int energy = int.Parse(Console.ReadLine());

            string argument;
            
            int totalBattles = 0;
            while ((argument = Console.ReadLine()) != "End of battle") 
            {
                int range = int.Parse(argument);
                  //   73     73
                if (energy >= range) 
                {
                    energy -= range;//after battle
                    totalBattles++;
                }
                else 
                {
                    Console.WriteLine($"Not enough energy! Game ends with {totalBattles} won battles and {energy} energy");
                    return;
                }

                if (totalBattles % 3 == 0 )
                {
                    energy += totalBattles;
                }

            
            }

            Console.WriteLine($"Won battles: {totalBattles}. Energy left: {energy}");
        }
    }
}