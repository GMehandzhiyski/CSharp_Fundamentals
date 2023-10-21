namespace _01.BonusScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            decimal numberOfStudents = decimal.Parse(Console.ReadLine());
            decimal numberOfLectures = decimal.Parse(Console.ReadLine());   
            decimal additionalBonus = decimal.Parse(Console.ReadLine());
            decimal maxScore = 0;
            decimal totalBonus;
            decimal maxAttendance = 0;
            for (decimal i = 1; i < numberOfStudents; i++)
            {
                decimal attendance = decimal.Parse(Console.ReadLine());
                //{total bonus} = {student attendances} / {course lectures} * (5 + {additional bonus})

                totalBonus = (attendance / numberOfLectures) * (5 + additionalBonus);

                if (totalBonus > maxScore)
                { 
                 maxScore = totalBonus;
                 maxAttendance = attendance;
                }

            }
            Console.WriteLine($"Max Bonus: {Math.Round(maxScore)}.");
            Console.WriteLine();
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");

        }
    }
}