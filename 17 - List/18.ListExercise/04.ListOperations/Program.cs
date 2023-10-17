/*
1 23 29 18 43 21 20
Add 5
Remove 5
Shift left 3
Shift left 1
End
*/

using System;

namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string commands = string.Empty;
            while ((commands = Console.ReadLine()) != "End")
            {
                string[] middleCommand = commands.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = middleCommand[0];

                if (command == "Add")
                {
                    int number = int.Parse(middleCommand[1]);
                    listInput.Add(number);

                }
                else if (command == "Insert")
                {

                    int index = int.Parse(middleCommand[2]);
                    bool isIndexValid = CheckValidIndex(index, listInput);
                    if (isIndexValid)
                    {
                        int number = int.Parse(middleCommand[1]);
                        listInput.Insert(index, number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command == "Remove")
                {
                   int index = int.Parse(middleCommand[1]);
                    bool isIndexValid = CheckValidIndex(index, listInput);
                    if (isIndexValid)
                    {

                        listInput.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }

                }
                else if (command == "Shift")
                {

                    int count = int.Parse(middleCommand[2]);
                    count = count % listInput.Count;
                    string direction = middleCommand[1];
                    if (direction == "left")
                    {
                        List<int> cutPart = listInput.GetRange(0, count);
                        listInput.RemoveRange(0, count);
                        listInput.InsertRange(listInput.Count, cutPart);

                    }
                    else if (direction == "right")
                    {
                        List<int> cutPart = listInput.GetRange(listInput.Count - count, count);
                        listInput.RemoveRange(listInput.Count - count, count);
                        listInput.InsertRange(0, cutPart);
                    }
                    else
                    {
                        continue;
                    }

                }
                else
                {
                    continue;
                }

              



            }

            Console.WriteLine(string.Join(" ", listInput));
        }


        private static bool CheckValidIndex(int index, List<int> listInput)
        {

            return index >= 0 && index < listInput.Count;
        }
    }
}