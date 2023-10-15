namespace _14.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumOfDigits = int.Parse(Console.ReadLine());
            bool isDevide;
            if (sumOfDigits % 8 == 0)
            {
                isDevide = true;
            }
            else
            {
                isDevide = false;
            }

            Console.WriteLine(isDevide);

         
        }
    }
}