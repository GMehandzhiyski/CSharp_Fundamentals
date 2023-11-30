namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string argumets = string.Empty;
            List<Student> students = new List<Student>();

            while ((argumets = Console.ReadLine()) != "end")
            {
                string[] inputInfo = argumets
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();


                string firstName = inputInfo[0];
                string lastName = inputInfo[1];
                int age = int.Parse(inputInfo[2]);
                string homeTown = inputInfo[3];

                Student student = new Student(firstName, lastName, age, homeTown);
                students.Add(student);
            }

            string finalFilter = Console.ReadLine();

            foreach (Student currStudent in students)
            {
                if (currStudent.HomeTown == finalFilter)
                {
                    Console.WriteLine($"{currStudent.FirstName} {currStudent.LastName} is {currStudent.Age} years old.");
                }
            }
        }
    }
    public class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string HomeTown { get; set; }
    }
}