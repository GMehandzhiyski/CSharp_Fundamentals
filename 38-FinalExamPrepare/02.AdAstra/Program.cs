using System.Text.RegularExpressions;

namespace _02.AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
(?:(?:#(?<food>[^#|]+)#(?<day>\d{2})/(?<month>\d{2})/(?<year>\d{2})#(?<calories>\d+)#)|\|(?<food>[^#|]+)\|(?<day>\d{2})/(?<month>\d{2})/(?<year>\d{2})\|(?<calories>\d+)\|)+

(?:#(?<food>[^#|]+)#(?<day>\d{2})/(?<month>\d{2})/(?<year>\d{2})#(?<calories>\d+)#)

\|(?<food>[^#|]+)\|(?<day>\d{2})/(?<month>\d{2})/(?<year>\d{2})\|(?<calories>\d+)
             
             
             */
            string regexPatern = @"(?:#(?<food>[^#|]+)#(?<day>\d{2})/(?<month>\d{2})/(?<year>\d{2})#(?<calories>\d+)#|(?<food>[^#|]+)\|(?<day>\d{2})/(?<month>\d{2})/(?<year>\d{2})\|(?<calories>\d+)\|)+";

            string inputFoodString = Console.ReadLine();

            MatchCollection Matches = Regex.Matches(inputFoodString, regexPatern);
            
            int totalCaories = 0;
            foreach (Match currCalories in Matches)
            {
                int calories = int.Parse(currCalories.Groups["calories"].Value);
                totalCaories += calories; 
            }

            double foodForDays = Math.Floor(totalCaories / 2000d);
            Console.WriteLine($"You have food to last you for: {foodForDays} days!");

            foreach (Match match in Matches)
            {
                string food = match.Groups["food"].Value;
                int day = int.Parse(match.Groups["day"].Value);
                string dayAddDigit = day.ToString("D2");
                int month = int.Parse(match.Groups["month"].Value);
                string monthAddDigit = month.ToString("D2");
                int year = int.Parse(match.Groups["year"].Value);
                string yearAddDigit = year.ToString("D2");
                int calories = int.Parse(match.Groups["calories"].Value);

                Console.WriteLine($"Item: {food}, Best before: {dayAddDigit}/{monthAddDigit}/{yearAddDigit},");
                Console.WriteLine($"Nutrition: {calories}");
            }

        }
    }
}