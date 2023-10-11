namespace _02.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            switch (comand)
            {
                case "add":
                    addMethod(numberOne, numberTwo);
                    break;
                case "multiplay":
                    multiplayMethod(numberOne, numberTwo);
                    break;
                case "subtract":
                    subtractMethod(numberOne, numberTwo);
                    break;
                case "divide":
                    divideMethod(numberOne, numberTwo);
                    break;
            }

        }

        private static void addMethod(int numberOne, int numberTwo)
        {
            int result = numberOne + numberTwo;
            Console.WriteLine(result);
        }
        private static void multiplayMethod(int numberOne, int numberTwo)
        {
            int result = numberOne * numberTwo;
            Console.WriteLine(result);
        }

        private static void subtractMethod(int numberOne, int numberTwo)
        {
            int result = numberOne - numberTwo;
            Console.WriteLine(result);
        }

        private static void divideMethod(int numberOne, int numberTwo)
        {
            int result = numberOne / numberTwo;
            Console.WriteLine(result);
        }

    }
}