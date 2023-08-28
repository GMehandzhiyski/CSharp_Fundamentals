using System.Transactions;

namespace _07.VendingMachine
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            double sum = 0;
            double sum1 = 0;

            string input1 = string.Empty;
            string input2 = string.Empty;

            while ((input1 = Console.ReadLine()) != "Start")
            {
                sum = double.Parse(input1);
               // sum1 += sum;

                if (sum == 0.1
                    || sum == 0.2
                    || sum == 0.5
                    || sum == 1
                    || sum == 2)
                {
                    sum1 += sum;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {sum}");
                }
                
            }

            while ((input2 = Console.ReadLine()) != "End")
            {
                if (input2 == "Nuts")
                {
                    if (sum1 >= 2.0)
                    {
                        sum1 -= 2.0;
                        Console.WriteLine("Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                }
                else if (input2 == "Water")
                {
                    if (sum1 >= 0.7)
                    {
                        sum1 -= 0.7;
                        Console.WriteLine("Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input2 == "Crisps")
                {
                    if (sum1 >= 1.5)
                    {
                        sum1 -= 1.5;
                        Console.WriteLine("Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input2 == "Soda")
                {
                    if (sum1 >= 0.8)
                    {
                        sum1 -= 0.8;
                        Console.WriteLine("Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input2 == "Coke")
                {
                    if (sum1 >= 1)
                    {
                        sum1 -= 1;
                        Console.WriteLine("Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }



            }

            Console.WriteLine($"Change: {sum1:F2}");

            //Console.WriteLine(sum1.ToString());
            //Console.WriteLine(sum.ToString());
        }
    }
}