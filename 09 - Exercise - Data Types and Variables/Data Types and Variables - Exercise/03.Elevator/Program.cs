namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberOfPeople = int.Parse(Console.ReadLine());
            double capacityOfElevator = int.Parse(Console.ReadLine());   

            double supposedCourses =Math.Ceiling( numberOfPeople / capacityOfElevator);
            Console.WriteLine(supposedCourses);
          

        }
    }
}