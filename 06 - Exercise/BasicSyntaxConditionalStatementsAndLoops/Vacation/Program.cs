using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int people = int.Parse(Console.ReadLine());
           string typeOfPeople = Console.ReadLine();
           string dayOfWeek = Console.ReadLine();

            if (typeOfPeople == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    if(people >= 30)
                    {
                        Console.WriteLine($"Total price: {((people * 8.45) - (people*8.45)*0.15)} ");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {(people * 8.45)} ");
                    }
                }
                else if (dayOfWeek == "Saturday")
                {
                    if (people >= 30)
                    {
                        Console.WriteLine($"Total price: {((people * 9.80) - (people * 9.80) * 0.15)} ");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {(people * 9.80)} ");
                    }
                }
                else if (dayOfWeek == "Sunday")
                {
                    if (people >= 30)
                    {
                        Console.WriteLine($"Total price: {((people * 10.46) - (people * 10.46) * 0.15)} ");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {(people * 10.46)} ");
                    }
                }


            }
            else if (typeOfPeople == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    if (people >= 100)
                    {
                        Console.WriteLine($"Total price: {(people * 10.90) - (10 * 10.90)} ");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {(people * 10.90)} ");
                    }
                }
                else if (dayOfWeek == "Saturday")
                {
                    if (people >= 100)
                    {
                        Console.WriteLine($"Total price: {(people * 15.60) - (10 * 15.60)} ");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {(people * 15.60)} ");
                    }
                }
                else if (dayOfWeek == "Sunday")
                {
                    if (people >= 100)
                    {
                        Console.WriteLine($"Total price: {(people * 16) - (10 * 16)} ");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {(people * 16)} ");
                    }
                }
                

            }
            else if (typeOfPeople == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    if (people >= 10 && people <= 20)
                    {
                        Console.WriteLine($"Total price: {(people * 15) - (people * 15)*0.05} ");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {(people * 15)} ");
                    }
                }
                else if (dayOfWeek == "Saturday")
                {
                    if (people >= 10 && people <= 20)
                    {
                        Console.WriteLine($"Total price: {(people * 20) - (people * 20) * 0.05} ");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {(people * 20)} ");
                    }
                }
                else if (dayOfWeek == "Sunday")
                {
                    if (people >= 10 && people <= 20)
                    {
                        Console.WriteLine($"Total price: {(people * 22.50) - (people * 22.50) * 0.05} ");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {(people * 22.50)} ");
                    }
                }


            }
        }
    }
}
