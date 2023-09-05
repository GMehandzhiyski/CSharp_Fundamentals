namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int totalCapacity = 0;

            for (int i = 1; i <= number; i++) 
            { 
                int addLitre = int.Parse(Console.ReadLine());

                totalCapacity += addLitre;

                if (totalCapacity > 255)
                {
                    totalCapacity -= addLitre;
                    Console.WriteLine("Insufficient capacity!");
                } 
            }
            Console.WriteLine(totalCapacity);
        }
    }
}