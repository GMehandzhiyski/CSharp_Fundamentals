namespace _03.Vacantion
{
   public class Program
    {
        static void Main(string[] args)
        {

            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            decimal firstPrice = 0M;
            decimal secondPrice = 0M;
            decimal finalPrice = 0M;

            if (type == "Students")
            {
                 if (day == "Friday")
                 {
                    firstPrice = 8.45M;
                 }
                 else if (day == "Saturday")
                 {
                    firstPrice = 9.80M;
                 }
                 else if (day == "Sunday")
                 {
                    firstPrice = 10.46M;
                 }

                secondPrice = firstPrice * people;

                if (people < 30)
                {
                    finalPrice = secondPrice;
                }
                else
                {
                    finalPrice = (secondPrice *(1M - (15M / 100M)));//minus 15%
                }   
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    firstPrice = 10.90M;
                }
                else if (day == "Saturday")
                {
                    firstPrice = 15.60M;
                }
                else if (day == "Sunday")
                {
                    firstPrice = 16M;
                }

                if (people < 100)
                {
                    secondPrice = firstPrice * people;
                    finalPrice = secondPrice;
                }
                else
                {
                    finalPrice = firstPrice * (people - 10);
                    
                }
            }
            else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    firstPrice = 15M;
                }
                else if (day == "Saturday")
                {
                    firstPrice = 20M;
                }
                else if (day == "Sunday")
                {
                    firstPrice = 22.50M;
                }

                secondPrice = firstPrice * people;

                if (people >= 10 && people <= 20)
                {

                    finalPrice = (secondPrice * (1M - (5M / 100M)));//minus 5%
                }
                else
                {
                    finalPrice = secondPrice;
                }
            }
            Console.WriteLine($"Total price: {finalPrice:F2}");
        }
    }
}