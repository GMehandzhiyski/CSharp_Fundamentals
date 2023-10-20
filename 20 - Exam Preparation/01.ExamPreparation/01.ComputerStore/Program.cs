using System.Data;
/*
1050
200
450
2
18.50 
16.86
special

 
 */
namespace _01.ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal priceBeforeTax = 0;

            while (true)
            {
                string arguments = Console.ReadLine();
                decimal vat = 1.2m;
                decimal discaunt = 0.1m;

                if (arguments == "special")
                {
                    decimal taxes = Math.Abs((priceBeforeTax - (priceBeforeTax * vat)));
                    decimal finalPrice = (priceBeforeTax * vat) -((priceBeforeTax * vat) * discaunt) ;

                    if (finalPrice == 0)
                    {
                        Console.WriteLine("Invalid order!");
                        return;
                    }
                    
                    PrintReceipt(priceBeforeTax, taxes, finalPrice );
                    return;

                }
                else if (arguments == "regular")
                {
                    decimal taxes = Math.Abs((priceBeforeTax - (priceBeforeTax * vat)));
                    decimal finalPrice = (priceBeforeTax * vat);

                    if (finalPrice == 0)
                    {
                        Console.WriteLine("Invalid order!");
                        return;
                    }

                    PrintReceipt(priceBeforeTax, taxes, finalPrice);
                    return;
                }

                decimal price = decimal.Parse(arguments);
                if (price > 0)
                {
                    priceBeforeTax += price;
                    
                }
                else
                {
                    Console.WriteLine("Invalid price!");
                }



            }
        }

        private static void PrintReceipt(decimal priceBeforeTax, decimal taxes, decimal finalPrice)
        {
            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {priceBeforeTax:F2}$");
            Console.WriteLine($"Taxes: {taxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {finalPrice:f2}$");
            

        }
    }
}