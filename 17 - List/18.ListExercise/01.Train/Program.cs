namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string command = null;

            while ((command = Console.ReadLine()) != "end") 
            {
                string[] middleString = command.Split();
                int passangers = 0;
                int passangersAdd = 0;
                if (middleString[0] == "Add" )
                {
                    passangers = int.Parse(middleString[1]);
                    wagons.Add(passangers);
                }
                else
                {

                    passangersAdd = int.Parse(middleString[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int fullSeats = wagons[i];
                        int freeSeats = maxCapacity - fullSeats;
                        if (freeSeats >= passangersAdd)
                        {
                            wagons[i] += passangersAdd;
                            break;
                        }
                        
                    }
                    

                }

            }

            Console.WriteLine(string.Join(" ", wagons));
        }

       
    }
}