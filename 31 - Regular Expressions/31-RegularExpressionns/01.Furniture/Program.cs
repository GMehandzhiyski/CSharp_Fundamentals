using System.Text.RegularExpressions;

namespace _01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listProsucts = new List<string>();

            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+.\d+)!(?<quantity>\d+)";
            decimal totalManey = 0;

            string arguments;
            while ((arguments = Console.ReadLine()) != "Purchase")
            {
                MatchCollection matches = Regex.Matches(arguments, pattern);

                
             
                foreach (Match match in matches)
                {
                    //Console.WriteLine(match.Groups["name"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    decimal quantity = decimal.Parse(match.Groups["quantity"].Value);
                    listProsucts.Add(match.Groups["name"].Value);
                    totalManey += price * quantity;

                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var name in listProsucts)
            {
                Console.WriteLine(name); 
            }
            Console.WriteLine($"Total money spend: {totalManey}");

        }
    }
}