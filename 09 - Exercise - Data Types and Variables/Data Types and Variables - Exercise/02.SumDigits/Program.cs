namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            int sum1 = 0;
            while (number != 0) 
            {
                sum = number % 10;
                sum1 += sum ;
                number = number / 10;

            }
            Console.WriteLine(sum1);




        }
    }
}