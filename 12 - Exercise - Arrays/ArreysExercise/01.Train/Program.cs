using System.Threading.Tasks.Dataflow;
  
namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());
            int [] wagon = new int [number];

            for (int i = 0; i < number; i++)
            {
                wagon[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine(string.Join(" ",wagon));
            Console.WriteLine(wagon.Sum());
        }
    }
}