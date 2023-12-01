namespace _04.Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudent = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();   

            for (int i = 0; i < numberOfStudent; i++)
            {
                string[] inputStudent = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string firstName = inputStudent[0];
                string lastName = inputStudent[1];  
                double grade = double.Parse(inputStudent[2]);

                Student student = new Student(firstName, lastName, grade); 
                students.Add(student);
            }

            foreach (Student currStudent in students.OrderByDescending(s => s.Grade))
            {
                Console.WriteLine($"{currStudent.FirstName} {currStudent.LastName}: {currStudent.Grade:f2}");
            }
        }
    }
    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}