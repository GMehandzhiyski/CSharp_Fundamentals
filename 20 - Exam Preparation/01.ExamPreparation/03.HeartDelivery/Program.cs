namespace _03.HeartDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> inputList = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string argumets;
            int indexPoint = 0;
            while ((argumets = Console.ReadLine()) != "Love!")
            {
                string[] comamds = argumets.Split();
                if (comamds[0] == "Jump")
                {
                    int length = int.Parse(comamds[1]);
                    indexPoint += length;
                    if (indexPoint >= inputList.Count)// ako prevyrti zapochva ot 0
                    {
                        indexPoint = 0;
                    }

                    if (inputList[indexPoint] != 0)
                    {
                        
                        inputList[indexPoint] -= 2;
                        

                        if (inputList[indexPoint] == 0) // ako stane 0 sled operaciata
                        {
                            Console.WriteLine($"Place {indexPoint} has Valentine's day.");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"Place {indexPoint} already had Valentine's day.");
                    }


                }

            }
            Console.WriteLine($"Cupid's last position was {indexPoint}.");
            if (inputList.Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                int failedPlaces = 0;
                for (int i = 0; i < inputList.Count; i++)
                {
                    if (inputList[i] > 0)
                    {
                        failedPlaces++;
                    }
                }

                Console.WriteLine($"Cupid has failed {failedPlaces} places.");
            }

        }
    }
}