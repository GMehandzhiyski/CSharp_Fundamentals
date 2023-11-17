using System.Text.RegularExpressions;

namespace _06.ExtractEmails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            //string regexPattern = @"(?<email>[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z][\w\.-]+\.[a-zA-Z]{2,})";
            string regexPattern = @"(?<email>(?<![^\s])([a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z]{2,}))";

            MatchCollection matches = Regex.Matches(inputString, regexPattern);

            foreach (Match match in matches) 
            {
                Console.WriteLine(match.Groups["email"].Value);
            }
        }
    }
}