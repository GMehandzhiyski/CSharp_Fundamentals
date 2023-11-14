using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            string pattern = @"\b(?<firstname>[A-Z][a-z]+) (?<secondname>[A-Z][a-z]+)\b";

            Regex regex = new Regex(pattern);

            MatchCollection matches = Regex.Matches(inputString, pattern);

            string finalStringName = string.Empty;
            foreach (Match match in matches)
            {
                finalStringName += match.Value + " ";
            }

            Console.WriteLine(finalStringName);

        }
    }
}