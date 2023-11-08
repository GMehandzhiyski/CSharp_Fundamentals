using System.Text;

namespace _05.DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = (Console.ReadLine());
            StringBuilder stringBuilderNumber = new StringBuilder();
            StringBuilder stringBuilderLetter = new StringBuilder();
            StringBuilder stringBuilderSpecialSymbol = new StringBuilder();


            foreach (var symbol in inputString)
            {
                if (char.IsDigit(symbol))
                {
                    stringBuilderNumber.Append(symbol);
                }
                else if (char.IsLetter(symbol))
                {
                    stringBuilderLetter.Append(symbol);    
                }
                else
                {
                    stringBuilderSpecialSymbol.Append(symbol);  
                }
            }

            PrintAllStrings(stringBuilderNumber, stringBuilderLetter, stringBuilderSpecialSymbol);
        }

        private static void PrintAllStrings(StringBuilder stringBuilderNumber, StringBuilder stringBuilderLetter, StringBuilder stringBuilderSpecialSymbol)
        {
            Console.WriteLine(stringBuilderNumber.ToString());
            Console.WriteLine(stringBuilderLetter.ToString());
            Console.WriteLine(stringBuilderSpecialSymbol.ToString());
        }
    }
}