    namespace _04.Students
{
    public class Program
    {
        static void Main(string[] args)
        {
            string arguments;
            List<Students> finalListStudents = new List<Students>();
            while ((arguments = Console.ReadLine()) != "end")
            {
                List<string> inputStidents = arguments
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string firstName = inputStidents[0];
                string lastName = inputStidents[1];
                string age = inputStidents[2];
                string homeTown = inputStidents[3];

                Students students = new Students(firstName, lastName, age, homeTown);
                finalListStudents.Add(students);

            }

            arguments = Console.ReadLine();
            FoundTown(arguments, finalListStudents);
        }

        private static void FoundTown(string arguments, List<Students> finalListStudents)
        {
            foreach (Students studentCycle in finalListStudents)
            {
                if (studentCycle.HomeTown == arguments)
                {
                    Console.WriteLine($"{studentCycle.FirstName} {studentCycle.LastName} is {studentCycle.Age} years old.");

                }

            }

        }
    }
    class Students
    {
        public Students(string firstName, string lastName, string age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string HomeTown { get; set; }


    }
}