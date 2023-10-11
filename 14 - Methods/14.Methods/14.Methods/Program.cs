namespace _14.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A();

        }
        // как се изкарва Call steck

        private static void A()
        {
            Console.WriteLine("B");
            B();
        }

        private static void B()
        {
            Console.WriteLine("b");
        
        }
    }
}