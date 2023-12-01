using System.Text.RegularExpressions;

namespace _602._Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string regexPattern = @"([#|]{1})(?<food>([A-Z][a-z]+(\s[A-Z][a-z]+)*))\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1";

            string textString = Console.ReadLine();

            MatchCollection matches = Regex.Matches(textString, regexPattern);
            int totalCalories = 0;
            foreach (Match currCalories in matches)
            {
                int calories = int.Parse(currCalories.Groups["calories"].Value);
                totalCalories += calories;
            }
            Console.WriteLine($"You have food to last you for: {totalCalories/2000} days!");

            foreach (Match match in matches)
            {
                string food = match.Groups["food"].Value;
                string date = match.Groups["date"].Value;
                int calories = int.Parse(match.Groups["calories"].Value);
                Console.WriteLine($"Item: {food}, Best before: {date}, Nutrition: {calories}");
            }

          
        }
    }
}