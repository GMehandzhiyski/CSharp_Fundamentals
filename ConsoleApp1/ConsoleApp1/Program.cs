namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            int numberValue = int.Parse(Console.ReadLine());

            while (numberValue > 0)
            {
                int digit = numberValue % 10;
                numberValue = numberValue / 10;

                Console.WriteLine(digit);   
            }
        }
    }
}