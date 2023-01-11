using System;

namespace StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int inputNum = int.Parse(Console.ReadLine());
            int midNum = inputNum;
            int fackt = 1;
            int totalfackt = 0;
          


            while (midNum > 0 )
            {
               int digit = midNum % 10;
               midNum /= 10;
             

                for (int i = 1; i <= digit; i++)
                {
                    fackt *= i;
                }

                totalfackt += fackt;
                fackt = 1;
            }
            if (inputNum == totalfackt)
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
