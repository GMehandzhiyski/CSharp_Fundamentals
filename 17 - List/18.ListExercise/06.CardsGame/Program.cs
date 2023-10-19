/*
 
20 30 40 50
10 20 30 40
20 30 40 50
10 20 30 40

 */
using System.Reflection.Metadata.Ecma335;

namespace _06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> secondHand = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();
            

             while (firstHand.Count != 0 || secondHand.Count != 0)
            {
                int counterEnd = 0;
                if (firstHand.Count <= secondHand.Count)
                {
                    counterEnd = firstHand.Count;
                }
                else
                {
                    counterEnd = secondHand.Count;  
                }

                for (int i = 0; i < counterEnd; i++)
                {
                    if (firstHand[i] > secondHand[i])
                    {
                        int moveCardSec = secondHand[i];
                        secondHand.RemoveAt(i);

                        int moveCardFir = firstHand[i];
                        firstHand.RemoveAt(i);

                        firstHand.Add(moveCardSec);
                        firstHand.Add(moveCardFir);
                        break;
                    }

                    //  30 20
                    //  40 30 40 50
                    else if (firstHand[i] < secondHand[i])
                    {
                        int moveCardFir = firstHand[i];
                        firstHand.RemoveAt(i);

                        int moveCardSec = secondHand[i];
                        secondHand.RemoveAt(i);

                        secondHand.Add(moveCardFir);
                        secondHand.Add(moveCardSec);
                        break;

                    }
                    else if (firstHand[i] == secondHand[i])
                    {
                        firstHand.RemoveAt(i);
                        secondHand.RemoveAt(i);
                        break;
                       
                    }
                    else
                    {
                        continue;
                    }

                    


                }
                if (firstHand.Count == 0)
                {
                  break;
                }
                else if (secondHand.Count == 0)
                {
                   break;
                }

            }
            if (firstHand.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");
            }
            else if (secondHand.Count == 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");
            }
           
          
        }

    }
}