using System.Text.RegularExpressions;

namespace _102.DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regexPattern = @"([=\/])((?<destination>[A-Z][A-Za-z]{2,}))\1";

            string inputString = Console.ReadLine();    

            MatchCollection matches = Regex.Matches(inputString, regexPattern);

            int stringLenght = 0;
            string destination = string.Empty;

            foreach (Match match in matches)
            {
                stringLenght += match.Groups["destination"].Value.Length;
                destination += match.Groups["destination"].Value + ", ";
            }

            PrintResultOfExample(destination, stringLenght);
        }

        private static void PrintResultOfExample(string destination, int stringLenght)
        {
           
            Console.WriteLine($"Destinations: {destination.TrimEnd(',', ' ')}");
            Console.WriteLine($"Travel Points: {stringLenght}");
        }
    }
}