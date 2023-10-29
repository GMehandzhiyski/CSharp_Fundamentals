namespace _104._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentNumber = int.Parse(Console.ReadLine());
            List <Students> finalStudentsList = new List<Students>();   

            for (int i = 0; i < studentNumber; i++) 
            {
                List <string> inputStudentList = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string firstName = inputStudentList[0];
                string lastName = inputStudentList[1];  
                double grade = double.Parse(inputStudentList[2]);

                Students students = new Students(firstName, lastName, grade);
                finalStudentsList.Add(students);

            }
            foreach (Students students in finalStudentsList.OrderByDescending(f => f.Grade))
            {
                Console.WriteLine($"{students.FirstName} {students.LastName}: {students.Grade:f2}");   
            }
        }
    }
    class Students
    {
        public Students(string firstName, string lastName, double grade)
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