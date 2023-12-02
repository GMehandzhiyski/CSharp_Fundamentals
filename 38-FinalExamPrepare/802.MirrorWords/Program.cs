using System.Text.RegularExpressions;

namespace _802.MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regexPattern = @"([#@]{1})(?<text1>[A-Za-z]{2,})\1{2}(?<text2>[A-Za-z]{2,})\1";

            string textString = Console.ReadLine();

            MatchCollection Matches = Regex.Matches(textString, regexPattern);

            int wordsCount = 0;
            string finalString = string.Empty;
            foreach (Match match in Matches) 
            {
                string mirrorWordTwo = string.Empty;
                string wordOne = match.Groups["text1"].Value;
                string wordTwo = match.Groups["text2"].Value;

                string wordTwoFinalResult = wordTwo;

                foreach (var currwordTwo in wordTwo)
                {
                    char currChar = currwordTwo;
                    wordTwo = wordTwo.Remove(0,1);
                    mirrorWordTwo = currChar + mirrorWordTwo;
                }

                if (wordOne == mirrorWordTwo)
                {
                    finalString = finalString + (wordOne + " <=> " + wordTwoFinalResult + ", ");
                }
                wordsCount++;
            }

            PrintFinalResult(finalString, wordsCount);
           

        }

        private static void PrintFinalResult(string finalString,int wordsCount)
        {
            if (finalString.Length <= 0
                && wordsCount <= 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
            else if (finalString.Length <= 0)
            {
                Console.WriteLine($"{wordsCount} word pairs found!");
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"{wordsCount} word pairs found!");
                Console.WriteLine("The mirror words are:");
                Console.WriteLine($"{finalString.TrimEnd(',', ' ')}");
            }
        }
    }
}