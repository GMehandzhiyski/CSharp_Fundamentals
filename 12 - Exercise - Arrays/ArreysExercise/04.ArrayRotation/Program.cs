namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

          

            for (int i = 1; i <= n; i++)
            {
                string temp = array[0];

                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                   
                }


                 array[array.Length - 1] = temp;

            }



            Console.WriteLine(string.Join(" ",array));
        }
    }
}