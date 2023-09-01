namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int sum1 = 0;

            for (int i = 0; i < number; i++) 
            { 
               char charecter = char.Parse( Console.ReadLine());

                sum = (int)(charecter);
                sum1 += sum;
            }

            Console.WriteLine($"The sum equals: {sum1}");
        }
    }
}