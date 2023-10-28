,using System;
using System.Runtime.CompilerServices;
/*
1 2 3 4 5 6 7 
Strike 3 2
 
52 74 23 44 96 110
Shoot 5 10
Shoot 1 80
Strike 2 1
Add 22 3
End
 
 */
namespace _03.MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> targetList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] middlecommand = command.Split();

                if (middlecommand[0] == "Shoot")
                {
                    int index = int.Parse(middlecommand[1]);
                    int power = int.Parse(middlecommand[2]);
                    bool isIndexValid = CheckIndex(index, targetList);

                    if (isIndexValid)
                    {
                      
                        int reducedValue = targetList[index] - power;
                        targetList[index] = reducedValue;

                        if (targetList[index] <= 0)
                        {
                            targetList.RemoveAt(index);
                        }
                       

                    }

                }
                else if (middlecommand[0] == "Add")
                {
                    int index = int.Parse(middlecommand[1]);
                    int value = int.Parse(middlecommand[2]);

                    bool isIndexValid = CheckIndex(index, targetList);

                    if (isIndexValid)
                    {
                        targetList.Insert(index, value);    
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }

                }
                else if (middlecommand[0] == "Strike")
                {
                    int index = int.Parse(middlecommand[1]);
                    int radius = int.Parse(middlecommand[2]);
                    bool isValidIndexOnStrike = CheckIndexStrike(index, radius, targetList);

                    if (isValidIndexOnStrike)
                    {
                        int countRadius = (radius * 2) + 1;
                        targetList.RemoveRange(index - radius, countRadius);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
                
            }

            Console.WriteLine(string.Join("|", targetList));
        }

        private static bool CheckIndexStrike(int index, int radius, List<int> targetList)
        {
            return ((((index + 1) - radius) >= radius) 
                    && ((targetList.Count - 1) - index) >= radius);
        }

        private static bool CheckIndex(int index, List<int> targetList)
        {


            return ((index >= 0) && (index < targetList.Count));
        }
    }
}