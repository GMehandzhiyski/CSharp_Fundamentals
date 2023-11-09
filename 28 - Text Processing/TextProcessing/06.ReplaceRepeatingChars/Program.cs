using System.Data.Common;
using System.Text;

namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            char lastLetter = '\0';
         
            StringBuilder sb = new StringBuilder(); 

            foreach (var currLetter in inputString)
            {
                if (currLetter != lastLetter)
                {
                    sb.Append(currLetter);
                    lastLetter = currLetter;
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}