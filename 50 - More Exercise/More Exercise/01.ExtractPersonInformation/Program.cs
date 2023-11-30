using System.Text.RegularExpressions;

namespace _01.ExtractPersonInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regexPatternName = @"@(?<name>[A-Za-z]+)";
            string regexPatternAge = @"\#(?<age>\d+)\*";

            int numberOflines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOflines; i++)
            {
                string inputline = Console.ReadLine();

                MatchCollection matchesName = Regex.Matches(inputline, regexPatternName);
                MatchCollection matchesAge = Regex.Matches(inputline, regexPatternAge);

                foreach (Match currMatchName in matchesName)
                {
                    string name = currMatchName.Groups["name"].Value;
                    int age = 0;
                    foreach (Match currMatchAge in matchesAge)
                    {
                        age = int.Parse(currMatchAge.Groups["age"].Value);
                    }
                  
                    Console.WriteLine($"{name} is {age} years old.");
                }


            }
        }
    }
}