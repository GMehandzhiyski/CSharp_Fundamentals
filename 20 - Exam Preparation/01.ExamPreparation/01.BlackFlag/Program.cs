namespace _01.BlackFlag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal days = Math.Abs(decimal.Parse(Console.ReadLine()));
            decimal plunderPerDay = Math.Abs(decimal.Parse(Console.ReadLine()));
            decimal expectedPlunder = Math.Abs(decimal.Parse(Console.ReadLine()));
           
            decimal addPlunderEvery3days =(plunderPerDay * 1.5m);
            decimal totalPlunder = 0;

            for (int i = 1; i < days + 1; i++) 
            {
                if (i % 3 == 0)
                {
                    totalPlunder += addPlunderEvery3days;

                }
                else if (i % 5 == 0)
                {
                    totalPlunder += plunderPerDay;
                    totalPlunder = totalPlunder - (totalPlunder * 0.30m);
                }
                else 
                {
                 totalPlunder += plunderPerDay;
                }
            
            }
            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else 
            {
                decimal percentLeft = (totalPlunder / expectedPlunder) * 100;
                Console.WriteLine($"Collected only {percentLeft:f2}% of the plunder.");
            }

            //Console.WriteLine(totalPlunder);

            // each 3 day they add +50%(day + 50%)
            // each 5 day they add -30%(total plunder - 30%)

        }
    }
}