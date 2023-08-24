namespace _02.Devision
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberDiv;

            if (number % 10 == 0) 
            {
                numberDiv = 10;
            }
            else if (number % 7 == 0) 
            {
                numberDiv = 7;
            }
            else if(number % 6 == 0) 
            {
                numberDiv = 6;
            }
            else if (number % 3 == 0)
            {
                numberDiv = 3;
            }
            else if (number % 2 == 0)
            {
                numberDiv = 2;
            }
        }
    }
}