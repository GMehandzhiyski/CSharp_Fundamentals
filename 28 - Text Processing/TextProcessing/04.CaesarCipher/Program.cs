using System.Text;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string inputString = Console.ReadLine();

            PrintEncryptString(inputString);
           
        }

        private static void PrintEncryptString(string inputString)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var letter in inputString)
            {
                sb.Append((char)(letter + 3));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}