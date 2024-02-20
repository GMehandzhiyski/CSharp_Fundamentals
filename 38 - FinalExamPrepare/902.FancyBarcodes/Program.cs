using System.Text.RegularExpressions;

namespace _902.FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regexPattern = @"([@]{1})#+(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])\1#+";

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string barcode = Console.ReadLine();

                MatchCollection mathes = Regex.Matches(barcode, regexPattern);

                foreach (Match match in mathes)
                {
                    string currBarcode = match.Groups["barcode"].Value;
                    string digits = string.Empty;

                    foreach (var currChar in currBarcode)
                    {
                        if (char.IsDigit(currChar))
                        {
                            digits = digits + currChar;
                        }
                    }

                    if (digits.Length > 0)
                    {
                        Console.WriteLine($"Product group: {digits}");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                }
                if (mathes.Count == 0) 
                {
                    Console.WriteLine("Invalid barcode");
                }
               
            }
        }
    }
}