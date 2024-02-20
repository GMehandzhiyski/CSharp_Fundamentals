using System;

namespace _503.P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Target> targetsList = new List<Target>();
            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "Sail")
            {
                
                string[] argument = arguments
                    .Split("||", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string city = argument[0];
                int population = int.Parse(argument[1]);
                int gold = int.Parse(argument[2]);
               
                Target target = new Target(city, population, gold);

                Target currCity = CheckCityIsAvalivable(targetsList, city);
                if (currCity != null)
                {
                    AddNewValue(currCity, population, gold);
                }
                else
                {
                    targetsList.Add(target);
                }
                  
               

               
            }

            while ((arguments = Console.ReadLine()) != "End")
            {
                string[] commands = arguments
                    .Split("=>",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = commands[0];
                string city = commands[1];

                Target currCity = targetsList.Where(t => t.City == city).FirstOrDefault();

                if (command == "Plunder")
                {
                    int people = int.Parse(commands[2]);
                    int gold = int.Parse(commands[3]);
                    AttackTown(currCity, people, gold, city);
                    Console.WriteLine($"{city} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (currCity.Population <= 0
                        || currCity.Gold <= 0)
                    {
                        Console.WriteLine($"{currCity.City} has been wiped off the map!");
                        targetsList.Remove(currCity);
                    }

                }
                else if (command == "Prosper")
                {
                    int gold = int.Parse(commands[2]);
                    if (gold > 0)
                    {
                        currCity.Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {currCity.City} now has {currCity.Gold} gold.");
                        continue;
                    }
                    Console.WriteLine("Gold added cannot be a negative number!");



                }
                else 
                {
                    continue;
                }
            }

            if ( targetsList.Count > 0 )
            {
                PrintFinalResult(targetsList);
                return;
            }

            Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
        }

        private static void PrintFinalResult(List<Target> targetsList)
        {
            Console.WriteLine($"Ahoy, Captain! There are {targetsList.Count} wealthy settlements to go to:");
            foreach (var currCity in targetsList)
            {
                Console.WriteLine($"{currCity.City} -> Population: {currCity.Population} citizens, Gold: {currCity.Gold} kg");
            }
        }

        private static void AttackTown(Target currCity, int people, int gold, string city)
        {
            
            currCity.Population -= people;
            currCity.Gold -= gold;
        }

        private static void AddNewValue(Target currCity, int population, int gold)
        {
            currCity.Population += population;
            currCity.Gold += gold;
        }

        public static Target CheckCityIsAvalivable(List<Target> targetsList, string city)
        {
            Target currCity = targetsList.Where(t => t.City == city).FirstOrDefault();
            return currCity;
        }
    }
    public class Target
    {
        public Target(string city, int population, int gold)
        {
            City = city;
            Population = population;
            Gold = gold;
        }
        public string City { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }
    }

}