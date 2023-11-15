using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string phoneNumber = Console.ReadLine();

             //string pattern = @"(?<phoneNumber>\+\d{3}\ \d{1} \d{3} \d{4})|(?<phoneNumber>\+\d{3}\-\d{1}-\d{3}-\d{4}\b)";
            string pattern = @"(?<phoneNumber>\+([359]+)([- ])2(\2)(\d{3})(\2)(\d{4})\b)";

            MatchCollection matches = Regex.Matches(phoneNumber, pattern);
            
            string finalString = string.Empty;
            foreach (Match match in matches)
            {
                finalString += match.Groups["phoneNumber"].Value + ", ";
            }
            finalString = finalString.TrimEnd(' ');
            finalString = finalString.TrimEnd(',');
            Console.WriteLine(finalString);
        }
    }
}