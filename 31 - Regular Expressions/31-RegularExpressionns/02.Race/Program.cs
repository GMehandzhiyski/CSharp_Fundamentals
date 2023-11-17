using System;
using System.ComponentModel;
using System.Text.RegularExpressions;


namespace _02.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputNames = Console.ReadLine()
                 .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            Dictionary<string, int> runners = new Dictionary<string, int>();
           
            

            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "end of race")
            {
                string regexLetters = @"(?<name>[A-Za-z]{1})";
                string regexDigits = @"(?<digit>\d{1})";

                MatchCollection matches1 = Regex.Matches(arguments, regexLetters);
                MatchCollection matches2 = Regex.Matches(arguments, regexDigits);

                string racerName = string.Empty;


                foreach (Match name in matches1)
                {
                    racerName += name.Groups["name"].Value;
                }

                int racerRange = 0;
                foreach (Match range in matches2)
                {
                    racerRange += int.Parse(range.Groups["digit"].Value);
                }
                int oldValue = 0;
                bool isRacerInList = ChekIsRacerIsAvalivable(runners, racerName);
                bool isNameIsInList = CheckIsNameIsInDB(inputNames, racerName);
                if (isRacerInList && isNameIsInList)
                {
                    foreach (var name in runners)
                    {
                        if (name.Key == racerName)
                        {
                            oldValue = name.Value;
                            runners[name.Key] = (oldValue + racerRange);
                        }

                    }
                }
                else if (!isRacerInList
                && isNameIsInList)
                {
                    runners.Add(racerName, racerRange);
                }
            }

         var sortedRunners = runners.OrderByDescending(r => r.Value)
                    .Take(3)
                    .ToList();

            
           Console.WriteLine($"1st place: {sortedRunners[0].Key}");
           Console.WriteLine($"2nd place: {sortedRunners[1].Key}");
           Console.WriteLine($"3rd place: {sortedRunners[2].Key}");






        }

        private static bool CheckIsNameIsInDB(List<string> inputNames, string racerName)
        {
            bool isNameIsInList = false;

            if (inputNames.Contains(racerName))
            {
                isNameIsInList = true;
            }


            return isNameIsInList;
        }

        private static bool ChekIsRacerIsAvalivable(Dictionary<string, int> runners, string racerName)
        {
            bool isRacerInList = false;
            if (runners.ContainsKey(racerName))
            {
                isRacerInList = true;
            }
            return isRacerInList;
        }

    }
}