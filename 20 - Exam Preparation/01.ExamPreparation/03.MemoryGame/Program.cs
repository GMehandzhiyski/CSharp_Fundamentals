namespace _03.MemoryGame
{
    /*
-5 -5 1 1 -3 -3 2 2
1 5
3 0
5 4
0 1
1 0
0 1
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string argument;
            int moveCount = 0;
            while ((argument = Console.ReadLine()) != "end") 
            {
                string[] argumetString = argument.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int index1 = int.Parse(argumetString[0]);
                int index2 = int.Parse(argumetString[1]);
                bool isIndexValid = CheckValidIndex(index1, index2,inputList);
               
   
                if (isIndexValid)
                {
                    if (inputList[index1] == inputList[index2])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {inputList[index1]}!");
                        if (index1 < index2)
                        {
                            inputList.RemoveAt(index2);
                            inputList.RemoveAt(index1);
                        }
                        else
                        {
                            inputList.RemoveAt(index1);
                            inputList.RemoveAt(index2);
                        }
                        
                        moveCount++;
                    }

                    else 
                    {
                        Console.WriteLine("Try again!");
                        moveCount++;
                    }

                }

                else 
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    // -2a -2a
                    // 0 1 2 3 4 5 6 7 8
                    // 1 2 3 4 2a 5 6 7 8 
                    //          4              8            2
                    int middleOfString = inputList.Count / 2;
                    inputList.Insert(middleOfString , "-2a");
                    inputList.Insert(middleOfString + 1, "-2a");
                    moveCount++;
                }

                if (inputList.Count == 0)
                {
                    Console.WriteLine($"You have won in {moveCount} turns!");
                    Console.WriteLine(string.Join(" ", inputList));
                    return;
                }
            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", inputList));
        }

        private static bool CheckValidIndex(int index1, int index2, List<string> inputList)
        {
           

            return (((0 <= index1) && (index1 < inputList.Count))
                && ((0 <= index2) && (index2 < inputList.Count))
                && index1 != index2);

        }
    }
}