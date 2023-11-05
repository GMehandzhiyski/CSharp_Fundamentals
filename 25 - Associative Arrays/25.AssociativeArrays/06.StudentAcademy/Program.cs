namespace _06.StudentAcademy
{
/*
5
Amanda
3.5
Amanda
4
Rob
5.5
Christian
5
Robert
6
*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string,decimal> studentsDataBase = new Dictionary <string,decimal> ();   

            int numberStudent = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberStudent; i++) 
            {
                string studentName = Console.ReadLine();
                decimal studentGrade = decimal.Parse(Console.ReadLine());

                if (!studentsDataBase.ContainsKey(studentName))
                {
                    studentsDataBase.Add(studentName, studentGrade);
                }
                else 
                {
                    FoundAverageStudentGrade(studentsDataBase,studentName,studentGrade);
                }
            }

            PrintStudentGrade(studentsDataBase);
          
        }

        private static void PrintStudentGrade(Dictionary<string, decimal> studentsDataBase)
        {
            foreach (KeyValuePair<string, decimal> currStudent in studentsDataBase)
            {

                if (currStudent.Value >= 4.50m)
                {
                    Console.WriteLine($"{currStudent.Key} -> {currStudent.Value:f2}");
                }
            }
        }

        private static void FoundAverageStudentGrade(Dictionary<string, decimal> studentsDataBase, string studentName, decimal studentGrade)
        {
            foreach (KeyValuePair <string, decimal> currStudent  in studentsDataBase)
            {
                if (currStudent.Key == studentName)
                {
                    studentsDataBase[currStudent.Key] = (currStudent.Value + studentGrade) / 2; 
                }
                
            }
        }
    }
}