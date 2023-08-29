using System.Diagnostics;

namespace _11.Order
{
   public class Program
    {
        static void Main(string[] args)
        {
            int numberOfOrder =int.Parse(Console.ReadLine());

            double generalSum = 0;
            double finishgeneralSum = 0;

            for (int i = 0; i < numberOfOrder; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                double days = double.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());

                generalSum = capsulePrice * days * capsuleCount;
                Console.WriteLine($"The price for the coffee is: ${generalSum:f2}");
                finishgeneralSum += generalSum;
            }
            
           
            Console.WriteLine($"Total: ${finishgeneralSum:f2}"); 


        }
    }
}