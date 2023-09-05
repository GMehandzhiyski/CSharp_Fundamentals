namespace _06.TriolesOfLatinsLatters
{
    internal class Program
    {
        static void Main(string[] args)
        { /*
            int number = int.Parse(Console.ReadLine());
            char offsetChar = 'a';
            int offset = (int)(offsetChar);

            for (int i = 1; i < number ; i++)
            {
                for (int j = 0; j < number ; j++)
                {

                    for (int k = 0; k < number ; k++)
                    {
                        char line1 = (char)(i);
                        char line2 = (char)(j);
                        char line3 = (char)(k);


                        char firstChar = (char)('a' + i);

                    }

                }*/
            int number = int.Parse(Console.ReadLine());


            for (char i = 'a'; i < 'a' + number; i++)
            {

                for (char k = 'a'; k < 'a' + number; k++)
                {


                    for (char l = 'a'; l < 'a' + number; l++)
                    {


                        Console.WriteLine($"{i}{k}{l}");
                    }

                }
            }
        }
    }
}