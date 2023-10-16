
/*

20 12 4 319 21 31234 2 41 23 4
Insert 50 2
Insert 50 5
Delete 4
end
*/


using System.Collections.Generic;
using System.Reflection.Metadata;

namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> changeList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "end") 
            {
                string [] midlleString = command.Split();

                if (midlleString[0] == "Delete")
                {
                    int elementDelete =int.Parse(midlleString[1]);
                    changeList.RemoveAll(x => x == elementDelete);
                }
                else if (midlleString[0] == "Insert")
                {
                    int element = int.Parse(midlleString[1]);
                    int position = int.Parse(midlleString[2]);
                    changeList.Insert(position, element);
                }
                else 
                {
                    continue;
                }
            
            }

            Console.WriteLine(string.Join(" ", changeList));
        }
    }
}