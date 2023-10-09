namespace ArreysExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] arr = Console.ReadLine().Split();

            //string temp = arr[0];

            //for (int i = 0 ; i < arr.Length - 1 ; i++) 
            //{
            //    arr[i] = arr[i +  1];

            //}
            //arr[arr.Length - 1] = temp;


            //Console.WriteLine(string.Join(" ", arr));

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    // Ако i е четно, пропусни текущата итерация и продължи със следващата.
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}