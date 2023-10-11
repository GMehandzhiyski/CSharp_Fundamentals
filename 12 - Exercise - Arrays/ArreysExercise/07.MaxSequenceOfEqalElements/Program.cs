namespace _07.MaxSequenceOfEqalElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;
            int bestCounter = 0;
            int tempValue = 0;
            int bestValue = 0;  
           

            for (int i = 0; i < array.Length - 1; i++) 
            {
                if (array[i] == array[i + 1])
                {
                    counter += 1;
                    tempValue = array[i];
                }
                else
                {
                    counter = 0;
                }

                if (bestCounter < counter)
                {
                    bestCounter = counter;
                    bestValue = tempValue;
                    
                }
            }

            for (int j = 0; j <= bestCounter; j++)
            {
                Console.Write(bestValue + " ");

            }

            //Console.WriteLine(bestCounter + 1);
            //Console.WriteLine(bestValue);
         
        }
    }
}