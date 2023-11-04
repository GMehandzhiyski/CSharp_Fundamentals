namespace _02.AMinerTask
{
/*
Gold
155
Silver
10
Copper
17
stop



     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, int> minerResource = new Dictionary<string, int> ();

            string argument;
            while ((argument = Console.ReadLine()) != "stop") 
            {
                string resource = argument;
                int quantity = int.Parse(Console.ReadLine());

                    if (!minerResource.ContainsKey(resource))
                    {
                        minerResource.Add(resource, quantity);
                    }
                    else
                    {
                        minerResource[resource] += quantity;
                    }
                    
                

            }
            PrintResources(minerResource);
        }

        private static void PrintResources(Dictionary<string, int> minerResource)
        {
            foreach (var currResource in minerResource)
            {
                Console.WriteLine($"{currResource.Key} -> {currResource.Value}");    
                
            }
        }
    }
}