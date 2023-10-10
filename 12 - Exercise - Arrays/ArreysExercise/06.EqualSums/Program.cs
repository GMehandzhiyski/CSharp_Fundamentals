namespace _06.EqualSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //int curr = 3;
            bool isHaveEqual = false;
            

            for (int curr  = 0; curr < array.Length; curr++)
            {
                int rightResult = 0;
                for (int i = curr + 1; i < array.Length; i++)
                {
                    rightResult += array[i];
                }
                int leftResult = 0;
                for (int i = curr - 1; i >= 0; i--)
                {
                    leftResult += array[i];
                }
            
                if (rightResult == leftResult) 
                {

                    Console.WriteLine(curr);
                    isHaveEqual = true;
                }

            }
            if (isHaveEqual == false)
            { 
                Console.WriteLine("no"); 
            }
           
        }
    }
}