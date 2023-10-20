using static System.Formats.Asn1.AsnWriter;
using System;

namespace Problem1_GuineaPig
{
    public class Program
    {
        static void Main(string[] args)
        {
            double food = 1000 * (double.Parse(Console.ReadLine()));
            double hay = 1000 * (double.Parse(Console.ReadLine()));
            double cover = 1000 * (double.Parse(Console.ReadLine()));
            double pigWeight = 1000 * (double.Parse(Console.ReadLine()));

            double totalfoodPerDay = 0;

            for (int day = 1; day <= 30; day++)
            {
               // totalfood = food + hay + cover;
               food -= 300; // each day

                if (day % 2 == 0) 
                {
                    double hayPerDay = (food * 0.05);
                    hay -= hayPerDay;
                }

                if (day % 3 == 0)
                {
                    double coverPerDay = pigWeight / 3;
                    cover -= coverPerDay;   
                }

                if (food <= 0 || hay <= 0 || cover <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
            }

           Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(food/1000):f2}, Hay: {(hay/1000):f2}, Cover: {(cover/1000):f2}.");




        }
    }
}