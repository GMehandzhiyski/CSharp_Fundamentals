namespace _05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string,string> studentDataBase = new Dictionary <string,string> ();

            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "end") 
            {
                List <string> commands = arguments
                    .Split(" : ",StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string courseName = commands[0];
                string studentName = commands[1];
                if (!studentDataBase.ContainsKey(studentName))
                {
                   
                    studentDataBase.Add(studentName, courseName);
                }
                else 
                {
                    continue;
                }
            
            }


            List <string> chekedCourse = new List <string> ();


            foreach (KeyValuePair <string,string> currCourse in studentDataBase)
            {
                int counterCourse = 0;

                if (!chekedCourse.Contains(currCourse.Value))
                {
                    foreach (KeyValuePair<string, string> foundCourse in studentDataBase)
                    {
                        if (currCourse.Value == foundCourse.Value)
                        {
                            counterCourse++;
                        }

                    }
                    chekedCourse.Add(currCourse.Value);


                    Console.WriteLine($"{currCourse.Value}: {counterCourse}");
                    foreach (KeyValuePair<string, string> currStudentName in studentDataBase)
                    {
                        if (currCourse.Value == currStudentName.Value)
                        {
                            Console.WriteLine($"-- {currStudentName.Key}");
                        }

                    }
                }
                else
                {
                    continue;
                }
            }
        }
    }
}