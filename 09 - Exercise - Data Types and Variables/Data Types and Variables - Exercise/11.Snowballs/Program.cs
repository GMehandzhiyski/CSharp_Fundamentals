using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowBalls = int.Parse(Console.ReadLine());


            int snowBallSnow = 0;
            int snowBallTime = 0;
            int snowBallQuality = 0;
            BigInteger snowBallValue = 0;
            BigInteger snowBallValueProces = 0;
            int snowBallSnowBig = 0;
            int snowBallTimeBig = 0;
            int snowBallQualityBig = 0;
            while (snowBalls > 0)
            {
               snowBallSnow = int.Parse(Console.ReadLine());
               snowBallTime = int.Parse(Console.ReadLine());   
               snowBallQuality = int.Parse(Console.ReadLine());

                snowBallValue = BigInteger.Pow((snowBallSnow / snowBallTime), snowBallQuality);

                if (snowBallValue >= snowBallValueProces)
                {
                    snowBallValueProces =  snowBallValue;
                    snowBallSnowBig = snowBallSnow;
                    snowBallTimeBig = snowBallTime;
                    snowBallQualityBig = snowBallQuality;
                }

                snowBalls--;
            }

            Console.WriteLine($"{snowBallSnowBig} : {snowBallTimeBig} = {snowBallValueProces} ({snowBallQualityBig})");
        
        }
    }
}