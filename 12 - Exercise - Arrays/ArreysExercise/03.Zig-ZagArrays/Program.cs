namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] arraysOne = new string[number];
            string[] arraysTwo = new string[number];

            for (int i = 0; i <= number - 1; i++) 
            {

                string[] current = Console.ReadLine().Split();

                if (i % 2 == 0)
                {
                    arraysOne[i] = current[0];
                    arraysTwo[i] = current[1];
                }
                else 
                {
                    arraysOne[i] = current[1];
                    arraysTwo[i] = current[0];
                }
                
               
            }

            Console.WriteLine(string.Join(" ", arraysOne));
            Console.WriteLine(string.Join(" ", arraysTwo));


        }
    }
}