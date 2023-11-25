namespace _503.P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Target> targetList = new List<Target>();
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
                targetList.Add(target);

            }

            while ((arguments = Console.ReadLine()) != "End")
            {
                Console.WriteLine("next while");
            }
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