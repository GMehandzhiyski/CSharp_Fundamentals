using System.Text.RegularExpressions;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string regexPattern = @"^(.+)\>(?<group1>\d{3})\|(?<group2>[a-z]{3})\|(?<group3>[A-Z]{3})\|(?<group4>([^<>]{3}))\<\1$";

            int numbers = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numbers; i++)
            {
                string finalString = string.Empty;
                string textString = Console.ReadLine();

                MatchCollection Matches = Regex.Matches(textString, regexPattern);

                if (Matches.Count != 0)
                {
                    
                    foreach (Match match in Matches)
                    {
                        string group1 = match.Groups["group1"].Value;
                        string group2 = match.Groups["group2"].Value;
                        string group3 = match.Groups["group3"].Value;
                        string group4 = match.Groups["group4"].Value;

                        finalString = finalString + group1 + group2 + group3 + group4;   
                    }
                    Console.WriteLine($"Password: {finalString}");
                }
                else 
                {
                    Console.WriteLine("Try another password!");
                }

                
            }
            

     
        }
    }
}