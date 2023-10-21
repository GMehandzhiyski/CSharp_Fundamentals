
using System;

namespace _02.MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;
            int couterRooms = 0;
            List <string> rooms = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            for (int i = 0; i < rooms.Count; i++)
            {
                string[] sepatateRooms = rooms[i].Split();
                string word = sepatateRooms[0];
                int value = int.Parse(sepatateRooms[1]);

                if (word == "potion")
                {
                    couterRooms++;
                    
                    if (health < 100) 
                    {
                        int healed;
                        int healedMiddle = 100 - health;
                        health += value;
                        if (health >= 100)
                        {
                            healed = healedMiddle;
                            health = 100;
                            
                        }
                        else 
                        {
                            healed = value;
                        }
                        Console.WriteLine($"You healed for {healed} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }

                }
                else if (word == "chest")
                {
                    couterRooms++;
                    bitcoins += value;  
                    Console.WriteLine($"You found {value} bitcoins.");
                }
                else
                {
                    couterRooms++;
                    int monsterAttack = value;
                    health -= value;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {word}.");
                    }
                    else 
                    {
                        Console.WriteLine($"You died! Killed by {word}.");
                        Console.WriteLine($"Best room: {couterRooms}");
                        return;
                    }
                  
                }
            }
            
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: { health}");
          
        }
    }
}