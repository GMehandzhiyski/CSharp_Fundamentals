
using System.Collections.Concurrent;
using System;

namespace _08.AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> inputList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] middleString = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (middleString[0] == "merge")
                {
                    int stratIndex = int.Parse(middleString[1]);
                    int ednIndex = int.Parse(middleString[2]);

                    List <string> margeList = inputList.GetRange(stratIndex, ednIndex + 1);
                    inputList.RemoveAt(stratIndex);

                    Console.WriteLine(string.Join(" ", margeList));
                    string outputMargeString = string.Empty;

                    foreach (string outputMarge in margeList)
                    {
                        
                        outputMargeString += outputMarge;

                    }
                    //Console.WriteLine(outputMargeString);


                }
                else if (middleString[0] == "divide")
                {

                    int index = int.Parse(middleString[1]);
                    int partitions = int.Parse(middleString[2]);
                    
                }
                else
                {
                    continue;
                }


            }
            Console.WriteLine(string.Join(" ", inputList));

        }
    }
}
// 0    1 2 3 4 5
// a    b c
// abc