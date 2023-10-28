using System.ComponentModel.Design;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> travelRouad = Console.ReadLine()
                .Split("||", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            int fuel = int.Parse(Console.ReadLine());
            int ammun = int.Parse(Console.ReadLine());

            for (int i = 0; i < travelRouad.Count; i++)
            {
                string[] command = travelRouad[i].Split(' ');
                if (command[0] == "Travel")
                {
                    int lightYear = int.Parse(command[1]);
                    if (lightYear <= fuel)
                    {
                        fuel -= lightYear;
                        Console.WriteLine($"The spaceship travelled {lightYear} light-years.");
                    }
                    else if (lightYear > fuel)
                    {
                        Console.WriteLine("Mission failed.");
                        return;
                    }

                }
                else if (command[0] == "Enemy")
                {
                    int armour = int.Parse(command[1]);
                    if (ammun >= armour)
                    {
                        Console.WriteLine($"An enemy with {armour} armour is defeated.");
                        ammun -= armour;
                    }
                    else if ((ammun < armour) && (fuel >= (armour * 2)))
                    {
                        Console.WriteLine($"An enemy with {armour} armour is outmaneuvered.");
                        fuel -=(armour*2);
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        return;
                    }
                }
                else if (command[0] == "Repair")
                {
                    int index = int.Parse(command[1]);
                    fuel += index;
                    ammun += (index * 2);
                    Console.WriteLine($"Ammunitions added: {(index * 2)}.");
                    Console.WriteLine($"Fuel added: {index}.");



                }
                else if (command[0] == "Titan")
                {
                    Console.WriteLine("You have reached Titan, all passengers are safe.");
                    return;
                }


            }


        }
    }
}