namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal numberOfDays = decimal.Parse(Console.ReadLine());
            decimal numberOfPlayers = decimal.Parse(Console.ReadLine());
            decimal gropsEnergy = decimal.Parse(Console.ReadLine());
            decimal watherPerDayForPerson = decimal.Parse(Console.ReadLine());
            decimal foodPerDayForPerson = decimal.Parse(Console.ReadLine());

            decimal totalWater = (watherPerDayForPerson * numberOfPlayers) * numberOfDays;
            decimal totalFood = (foodPerDayForPerson * numberOfPlayers) * numberOfDays;
            for (int i = 1; i < numberOfDays +1 ; i++)
            {
                decimal energyLoss = decimal.Parse( Console.ReadLine());
                
                gropsEnergy -= energyLoss;

                if (gropsEnergy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
                    return;
                }

                if (i % 2 == 0) 
                {
                    gropsEnergy = gropsEnergy * 1.05m;
                    totalWater = totalWater - (totalWater * 0.30m);

                }
                if (i % 3 == 0) 
                {
                    totalFood -= totalFood / numberOfPlayers;
                    gropsEnergy = gropsEnergy * 1.10m;

                }

               

            }

                Console.WriteLine($"You are ready for the quest. You will be left with - {gropsEnergy:f2} energy!");
        }
    }
}