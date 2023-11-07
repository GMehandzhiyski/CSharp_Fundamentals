namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString;
            while ((inputString = Console.ReadLine()) != "end" ) 
            {
                string reversedString = string.Empty;
                for (int i = inputString.Length -1 ; i >= 0 ; i--)
                {
                    reversedString += inputString[i];

                }
                Console.WriteLine($"{inputString} = {reversedString}");
            }
        }
    }
}