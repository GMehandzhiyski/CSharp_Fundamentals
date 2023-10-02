using System;
using System.Xml.Serialization;

namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int day = 0;
            int spices = 0;
            int spices1 = 0;


            while (startingYield >= 100)
            {
                spices1 = startingYield - 26;
                spices = spices + spices1;
                startingYield -= 10;

                day++; 
            }

            if (startingYield <= 0)
            {
                Console.WriteLine(day);
                Console.WriteLine("0");

            }
            else
            {
                Console.WriteLine(day);
                Console.WriteLine(spices - 26);
            }

        }
    }
}