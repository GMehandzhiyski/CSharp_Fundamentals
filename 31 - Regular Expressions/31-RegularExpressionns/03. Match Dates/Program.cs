using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    public class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            string pattern = @"((?<day>\d{2})([\/\-.])(?<month>Jan|Feb|Mar|Apr|May|Jun|Jul|Aug|Sep|Oct|Nov|Dec)\2(?<year>\d{4}))";

            MatchCollection matches = Regex.Matches(inputString, pattern);

            foreach (Match match in matches) 
            {
                var day = match.Groups["day"].Value;
                var month = match.Groups["month"].Value;
                var year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}