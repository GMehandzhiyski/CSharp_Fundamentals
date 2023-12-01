using System.Diagnostics;
using System.Text.RegularExpressions;

namespace _702.DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regexPattern = @"([=\/]{1})(?<place>[A-Z][A-Za-z]{2,})\1";

            string inputString = Console.ReadLine();    

            MatchCollection matches = Regex.Matches(inputString, regexPattern);
            string destination = string.Empty;
            int travelPoints = 0;
            foreach (Match match in matches) 
            { 
                string place = match.Groups["place"].Value;
                destination += place + ", ";
                travelPoints += place.Length;
            }
            Console.WriteLine($"Destinations: {destination.TrimEnd(',',' ')}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}