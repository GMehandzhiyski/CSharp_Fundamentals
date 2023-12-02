namespace _703.PlantDiscovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Plant> plants = new List<Plant>(); 

            for (int i = 0; i < number; i++)
            {
                string[] arguments = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string plantName = arguments[0];
                int rarity = int.Parse(arguments[1]);
                Plant plant = new Plant(plantName, rarity);

                bool isPlantIsAvalivable = CheckForPLant(plants, plantName);
                if (isPlantIsAvalivable)
                {
                    ChangeRarity(plants, rarity, plantName);
                }
                else
                {
                    plants.Add(plant);
                }
                
            }
            string argumets = string.Empty;
            while ((argumets = Console.ReadLine()) != "Exhibition")
            {
                string[] commands = argumets
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string[] argument = commands[1]
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = commands[0];
                string plantName = argument[0];
                
                if (command == "Rate")
                {
                    double rating = int.Parse(argument[1]);
                    bool isPlantIsAvalivable = CheckForPLant(plants, plantName);
                    if (isPlantIsAvalivable)
                    {
                        AddRating(plants, plantName, rating);
                    }
                    else 
                    {
                        Console.WriteLine("error");
                    }
                  
                }
                else if (command == "Update")
                {
                    int newRariry = int.Parse(argument[1]);
                    bool isPlantIsAvalivable = CheckForPLant(plants, plantName);
                    if (isPlantIsAvalivable)
                    {
                        UpdateRarity(plants, plantName, newRariry);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                else if (command == "Reset")
                {
                    bool isPlantIsAvalivable = CheckForPLant(plants, plantName);
                    if (isPlantIsAvalivable)
                    {
                        RemoveRating(plants, plantName);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                else
                {
                    continue;
                }
            }

            PrintFinalResult(plants);
        }

        private static void PrintFinalResult(List<Plant> plants)
        {
            Console.WriteLine("Plants for the exhibition:");

            foreach (var currPlant in plants)
            { 
                double averageRating = 0.00;

                if (currPlant.Rating.Count > 0)
                {
                    foreach (var currRating in currPlant.Rating)
                    {
                        averageRating = currPlant.Rating.Average();
                    }
                }
               
                Console.WriteLine($" - {currPlant.PlantName}; Rarity: {currPlant.Rarity}; Rating: {averageRating:f2}");
            }
        }

        private static void RemoveRating(List<Plant> plants, string plantName)
        {
            foreach (var currPlant in plants)
            {
                if (currPlant.PlantName == plantName)
                { 
                    currPlant.Rating.Clear();
                    break;
                }
            }
        }

        private static void UpdateRarity(List<Plant> plants, string plantName, int newRariry)
        {
            foreach (var currPlant in plants)
            {
                if (currPlant.PlantName == plantName)
                { 
                    currPlant.Rarity = newRariry;
                    break;
                }
            }
        }

        private static void AddRating(List<Plant> plants, string plantName, double rating)
        {
            foreach (var currPlant in plants)
            {
                if (currPlant.PlantName == plantName)
                {
                    currPlant.Rating.Add(rating);
                    break;
                }
            }
        }

        private static void ChangeRarity(List<Plant> plants, int rarity, string plantName)
        {
            foreach (var currPlant in plants)
            {
                if(currPlant.PlantName == plantName)
                { 
                    currPlant.Rarity = rarity;
                    break;
                }
            }
        }

        private static bool CheckForPLant(List<Plant> plants, string plantName)
        {
            bool isPlantIsAvalivable = false;
            Plant currPlant = plants.FirstOrDefault(p => p.PlantName == plantName);
            if (currPlant != null) 
            {
                return isPlantIsAvalivable = true;
            }
            return isPlantIsAvalivable;
        }
    }
    public class Plant
    {
        public Plant(string plantName, int rarity)
        {
            PlantName = plantName;
            Rarity = rarity;
            Rating = new List<double>();
        }

        public string PlantName { get; set; }
        public int Rarity { get; set; }
        public List <double> Rating { get; set; }
    }
}