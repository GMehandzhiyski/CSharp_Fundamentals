namespace _06.StrongNumber
{
    public class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int originalNum = number;   
            int digit;
            int sum = 1;
            int secondSum = 0;

            while (number > 0)
            {
                sum = 1;
                digit = number % 10;
                number = number / 10;
                //Console.WriteLine(digit);
                
                for (int i = 1; i <= digit; i++)
                {
                    sum *= i;
                }

                secondSum = sum + secondSum;

            }

            if (originalNum== secondSum)
            {
                Console.WriteLine("yes");
            }
            else 
            {
                Console.WriteLine("no");
            }
        }
    }
}