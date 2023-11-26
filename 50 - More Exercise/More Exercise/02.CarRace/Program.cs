namespace _02.CarRace
{
/*
0 29 13 0 13 0 21 0 14 82 0 
*/
    internal class Program
    {
        static void Main(string[] args)
        {
           List <int> inputString = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int raceLength = inputString.Count / 2;
            decimal leftRaceCar = 0;
            decimal rightRaceCar = 0;

            if (inputString[0] == 0)
            {
                leftRaceCar = 1;
            }
            else 
            {
                leftRaceCar = 0;
            }
            if (inputString[inputString.Count - 1] == 0)
            {
                rightRaceCar = 1;
            }
            else
            {
                leftRaceCar = 0;
            }
             
            for (int i = 0; i < raceLength; i++)
            {
                if (inputString[i] != 0)
                {
                    int currValue = inputString[i];
                    leftRaceCar += currValue;
                }
                else 
                {
                    leftRaceCar *= 0.8m;
                }

            }

            for (int i = inputString.Count - 1 ; i > raceLength; i--)
            {
                if (inputString[i] != 0)
                {
                    int currValue = inputString[i];
                    rightRaceCar += currValue;
                }
                else
                {
                    rightRaceCar *= 0.8m;
                }
            }

            if (leftRaceCar <= rightRaceCar)
            {
                Console.WriteLine($"The winner is left with total time: {leftRaceCar}");
            }
            else 
            {
                Console.WriteLine($"The winner is right with total time: {rightRaceCar}");
            }
           

        }
    }
}