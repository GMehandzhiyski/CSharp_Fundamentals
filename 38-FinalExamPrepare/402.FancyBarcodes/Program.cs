using System;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace _402.FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string regexPattern = @"[@]{1}[#]+(?<string>[A-Za-z0-9]{5,}[A-Za-z]+[0-9]*[A-Z0-9]*)[@]{1}[#]+";

            for (int i = 0; i < number; i++)
            {
                string inputString = Console.ReadLine();

                MatchCollection Matches = Regex.Matches(inputString, regexPattern);

                if (Matches.Count != 0)
                {
                    string productGroup =  FoundProductGroup(inputString, regexPattern, Matches);

                    PrintFinalResul(productGroup);
                    
                }
                else 
                {
                    Console.WriteLine("Invalid barcode");
                }

               

            }

        }

        private static void PrintFinalResul(string productGroup)
        {
            string productGroupFinal = string.Empty;

            if (productGroup != "")
            {
                productGroupFinal = productGroup;
            }
            else 
            {
                productGroupFinal = "00";
            }
            Console.WriteLine($"Product group: {productGroupFinal}");
        }

        public static string FoundProductGroup(string inputString, string regexPattern, MatchCollection Matches)
        {
            string digits = string.Empty;
           

            foreach (Match item in Matches)
            {
                string barcode = item.Groups["string"].Value;

                foreach (var currChar in barcode)
                {
                    bool isDigit = char.IsDigit(currChar);
                    if (isDigit) 
                    {
                        digits += currChar;
                    }
                }
            }
            return digits;
        }

    }
}