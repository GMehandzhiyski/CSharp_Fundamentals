using System.Security.Cryptography;

namespace _04.Students
{
    public class Program
    {
        static void Main(string[] args)
        {
            string arguments;
            List<Students> studentsList = new List<Students>();

            while ((arguments = Console.ReadLine()) != "end")
            {
                List<string> argumetsList = arguments
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string name = argumetsList[0];
                string lastName = argumetsList[1];
                int age = int.Parse(argumetsList[2]);
                string town = argumetsList[3];



                bool isStudentExisting = IsStudentExisting(studentsList, name, lastName);
                if (isStudentExisting)
                {
                    Students existingStudent = GetStident(studentsList, name, lastName);
                    existingStudent.Name = name;
                    existingStudent.LastName = lastName;
                    existingStudent.Age = age;
                    existingStudent.Town = town;

                }
                else
                {
                    Students students = new Students(name, lastName, age, town);
                    studentsList.Add(students);
                }

            }

            arguments = Console.ReadLine();
            GetTown(arguments, studentsList);



        }

        private static void GetTown(string arguments, List<Students> studentsList)
        {
            Students existingTown = null;

            foreach (var students in studentsList)
            {
                if (students.Town == arguments)
                {

                    Console.WriteLine($"{students.Name} {students.LastName} is {students.Age} years old.");

                }
            }


        }

        static Students GetStident(List<Students> studentsList, string name, string lastName)
        {
            Students existingStudent = null;

            foreach (Students student in studentsList)
            {
                if (student.Name == name && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }

        static bool IsStudentExisting(List<Students> studentsList, string name, string lastName)
        {
            foreach (var item in studentsList)
            {
                if (item.Name == name && item.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Students
    {
        public Students(string name, string lastName, int age, string town)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Town = town;
        }

        public string Name { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }


    }
}