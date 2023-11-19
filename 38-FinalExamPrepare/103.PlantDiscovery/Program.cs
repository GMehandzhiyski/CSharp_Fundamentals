namespace _103.PlantDiscovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PlantClass> plantsList = new List<PlantClass> ();

            int number = int.Parse(Console.ReadLine());
            if (number <= 0) 
            {
                return;
            }

            for (int i = 0; i < number; i++)
            {
                string[] plantsInput = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string plant = plantsInput[0];
                int rarity = int.Parse(plantsInput[1]);
                decimal rating = 0;
                decimal rateRaiting = 0;
                PlantClass plantClass = new PlantClass(plant, rarity, rating, rateRaiting);
               
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
                            UpdateOldRatingWithNew(plant, rating, plantsList);

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
                decimal finalRaiting = 0;
                if (currPlants.RateRating > 0)
                {
                   finalRaiting = currPlants.Rating / currPlants.RateRating;
                }
                else
                {
                    finalRaiting = currPlants.Rating;
                }

                Console.WriteLine($"- {currPlants.Plant}; Rarity: {currPlants.Rarity}; Rating: {finalRaiting:f2} ");
            }
        }

        private static void RemoveRatingOnPlant(string plant, List<PlantClass> plantsList)
        {

            foreach (PlantClass currPlant in plantsList)
            {
                if (currPlant.Plant == plant)
                { 
                    currPlant.Rating = 0;
                    break;
                }
            }
        }

        private static void UpdateOldRatingWithNew(string plant, int rating, List<PlantClass> plantsList)
        {
            foreach (PlantClass currPlant in plantsList)
            {
                if (currPlant.Plant == plant)
                {
                    currPlant.Rating += rating;
                    currPlant.RateRating++;
                    break;
                }
            }
        }

        private static void UpdateOldRatityWithNew(string plant, int rarity, List<PlantClass> plantsList)
        {
            foreach (PlantClass currPlant in plantsList)
            {
                if (currPlant.Plant == plant)
                { 
                    currPlant.Rarity = rarity;
                    break;
                }
            }
        }

        private static bool CheckPlantIsAvalivable(string plant, List<PlantClass> plantsList)
        {
            bool isPlantIsInDB = false;
            foreach (PlantClass currPlant in plantsList)
            {
                if (currPlant.Plant == plant)
                {
                    isPlantIsInDB = true;
                    break;
                }
            }
            return isPlantIsInDB;
        }

    }
    public class PlantClass
    {
        public PlantClass(string plant,int rarity,decimal rating,decimal rateRating)
        {
            Plant = plant;
            Rarity = rarity;
            Rating = rating;
            RateRating = rateRating;

        }
        public string Plant { get; set; }

        public int Rarity { get; set; }

        public decimal Rating { get; set; }

        public decimal RateRating { get; set; }
    }
}