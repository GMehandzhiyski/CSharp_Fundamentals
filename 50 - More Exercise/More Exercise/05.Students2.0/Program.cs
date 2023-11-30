using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace _05.Students2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "end")
            {
                string[] argument = arguments
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string firstName = argument[0];
                string lastName = argument[1];
                int age = int.Parse(argument[2]);
                string homeTown = argument[3];

                Student student = new Student(firstName, lastName, age, homeTown);
               

                bool isHaveStudent = CheckStudentInList(students, firstName, lastName);
                if (!isHaveStudent)
                {
                    students.Add(student);
                }
                else
                {
                    OverwriteStudent(students, firstName, lastName, age, homeTown);
                }
            }

            string finalTown = Console.ReadLine();
            foreach (var currStudent in students)
            {
                if (currStudent.HomeTown == finalTown)
                {
                    Console.WriteLine($"{currStudent.FirstName} {currStudent.LastName} is {currStudent.Age} years old.");
                }
            }
        }

        private static void OverwriteStudent(List<Student> students, string firstName, string lastName, int age, string homeTown)
        {
            Student currStudent = students.Where(s => (s.FirstName == firstName && s.LastName == lastName)).FirstOrDefault();

            currStudent.Age = age;
            currStudent.HomeTown = homeTown;    
        }

        private static bool CheckStudentInList(List<Student> students, string firstName, string lastName)
        {
            bool isHaveStudent = false;

            Student currStudent = students.Where(s => (s.FirstName == firstName && s.LastName == lastName)).FirstOrDefault();

            if (currStudent != null)
            {
                if (currStudent.FirstName == firstName
                       && currStudent.LastName == lastName)
                {
                    return isHaveStudent = true;
                }
            }
               
            return isHaveStudent;
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