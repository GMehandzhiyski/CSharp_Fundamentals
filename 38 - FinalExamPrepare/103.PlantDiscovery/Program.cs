namespace _103.PlantDiscovery
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Plant> plantsList = new List<Plant> ();
            //Dictionary<string, Plant> plants = new Dictionary<string, Plant> ();

            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] plantsInput = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string plant = plantsInput[0];
                int rarity = int.Parse(plantsInput[1]);
                Plant plantClass = new Plant(plant, rarity);
               
                bool isPlantIsInDB = CheckPlantIsAvalivable(plant, plantsList);

                if (isPlantIsInDB)
                {
                    UpdateOldRatityWithNew(plant, rarity, plantsList);
                }   
                else
                {
                    plantsList.Add(plantClass);
                }
                
            }

            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "Exhibition")
            {
                string[] commands = arguments
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (commands.Length > 1)
                {
                    string command = commands[0];
                    bool isPlantNameCorrect = CheckPlantIsAvalivable(commands[1], plantsList);
                    if (isPlantNameCorrect)
                    {
                        if (command == "Rate:")
                        {
                            string plant = commands[1];
                            int rating = int.Parse(commands[3]);
                            AddRatingToPlant(plant, rating, plantsList);

                        }
                        else if (command == "Update:")
                        {
                            string plant = commands[1];
                            int newRating = int.Parse(commands[3]);
                            UpdateOldRatityWithNew(plant, newRating, plantsList);
                        }
                        else if (command == "Reset:")
                        {
                            string plant = commands[1];
                            RemoveRatingOnPlant(plant, plantsList);
                        }
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

            Console.WriteLine("Plants for the exhibition:");

            foreach (var currPlants in plantsList)
            {
                decimal plantRating = 0;

                if(currPlants.Rating.Count > 0)
                {
                    plantRating = currPlants.Rating.Average();
                }
                Console.WriteLine($"- {currPlants.Name}; Rarity: {currPlants.Rarity}; Rating: {plantRating:F2} ");
            }
        }

        private static void RemoveRatingOnPlant(string plant, List<Plant> plantsList)
        {

            foreach (Plant currPlant in plantsList)
            {
                if (currPlant.Name == plant)
                { 
                    currPlant.Rating.Clear();
                    break;
                }
            }
        }

        private static void AddRatingToPlant(string plant, int rating, List<Plant> plantsList)
        {
            foreach (Plant currPlant in plantsList)
            {
                if (currPlant.Name == plant)
                {
                    currPlant.Rating.Add(rating);
                    break;
                }
            }
        }

        private static void UpdateOldRatityWithNew(string plant, int rarity, List<Plant> plantsList)
        {
            foreach (Plant currPlant in plantsList)
            {
                if (currPlant.Name == plant)
                { 
                    currPlant.Rarity = rarity;
                    return;
                }
            }
        }

        private static bool CheckPlantIsAvalivable(string plant, List<Plant> plantsList)
        {
            bool isPlantIsInDB = false;
            foreach (Plant currPlant in plantsList)
            {
                if (currPlant.Name == plant)
                {
                    isPlantIsInDB = true;
                    break;
                }
            }
            return isPlantIsInDB;
        }

    }
    public class Plant
    {
        public Plant(string name,int rarity)
        {
            Name = name;
            Rarity = rarity;
            Rating = new List<decimal>();
        }
        public string Name { get; set; }

        public int Rarity { get; set; }

        public List<decimal> Rating { get; set; }
    }
}