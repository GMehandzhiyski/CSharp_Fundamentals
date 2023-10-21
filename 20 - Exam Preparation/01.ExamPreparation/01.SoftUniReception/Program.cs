using System.Xml.Schema;

namespace _01.SoftUniReception
{
    public class Program
    {
        static void Main(string[] args)
        {

            double employeeHelpPerHour1 = double.Parse(Console.ReadLine());
            double employeeHelpPerHour2 = double.Parse(Console.ReadLine());
            double employeeHelpPerHour3 = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine()); ;
            double needHour = 0;
            double employeeBreak = 0;
            double employeeHelpPerHour1Positive;
            double employeeHelpPerHour2Positive;
            double employeeHelpPerHour3Positive;
            double studantsPositive;

            
            if (employeeHelpPerHour1 <= 0)
            {
                employeeHelpPerHour1Positive = 0;
            }

            else 
            {
                employeeHelpPerHour1Positive = employeeHelpPerHour1;
            }

            if (employeeHelpPerHour2 <= 0)
            {
                employeeHelpPerHour2Positive = 0;
            }
            else
            {
                employeeHelpPerHour2Positive = employeeHelpPerHour2;
            }

            if (employeeHelpPerHour3 <= 0)
            {
                employeeHelpPerHour3Positive = 0;
            }
            else
            {
                employeeHelpPerHour3Positive = employeeHelpPerHour3;
            }

            if (students <= 0)
            {
                studantsPositive = 0;
            }

            else
            {
                studantsPositive = students;
            }
            double totalStudentPerHour = employeeHelpPerHour1Positive + employeeHelpPerHour2Positive + employeeHelpPerHour3Positive;

            if ((0 < totalStudentPerHour) && (0 < students))
            { ///      20               15
                if (studantsPositive > totalStudentPerHour)
                {
                    needHour = Math.Ceiling(studantsPositive / totalStudentPerHour);

                    if (needHour > 3)
                    {
                        employeeBreak = Math.Floor(needHour / 3);
                    }
                    else if (needHour == 3)
                    {
                        employeeBreak = 1;
                    }
                }

                else if(studantsPositive <= totalStudentPerHour)
                {
                    needHour = 1;
                }
            }
            else
            {
                needHour = 0;
                employeeBreak = 0;
            }
            Console.WriteLine($"Time needed: {needHour + employeeBreak}h.");
        }
    }
}