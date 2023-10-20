using System.Linq;
using System.Runtime.CompilerServices;

namespace _02.TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int people = int.Parse(Console.ReadLine());
            int startPeople = people;
            List<int> lift = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int cabinSpace = 4;
            for (int i = 0; i < lift.Count; i++)
            {
                if (lift[i] < 4) //free space
                {//        2      =       2   -    4
                    int freeSpace = Math.Abs(lift[i] - cabinSpace);
                    //   20-2         2
                    int fullPlaceInCabin = 0;
                    if (people < freeSpace)
                    {
                        fullPlaceInCabin = lift[i] + people;
                        lift[i] = fullPlaceInCabin;
                        people = 0;
                    }
                    else
                    {
                        people -= freeSpace;
                        fullPlaceInCabin = lift[i] + freeSpace;
                        lift[i] = fullPlaceInCabin;
                    }


                }


            }
            int sumList = lift.Sum();
            int liftIsFull = cabinSpace * (lift.Count);
            if (people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (people == 0 && (liftIsFull == sumList))
            {
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (people == 0 && (liftIsFull != sumList))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", lift));
            }
          
        }
    }
}