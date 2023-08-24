namespace _05.Login
{
    public class Program
    {
        static void Main(string[] args)
        { 

           string userName = Console.ReadLine();
            string logName = string.Empty;
            string passNameRev = string.Empty;

            for (int i = userName.Length - 1; i >= 0; i--) 
            {
                passNameRev += userName[i];
               // Console.WriteLine(passName[i]);
            }

            for (int i = 0; i < 3; i++)
            {
                logName = Console.ReadLine();
                if (logName == passNameRev)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                }

               
            }
            if (logName != passNameRev)
            {
                Console.WriteLine($"User {userName} blocked!");
            }
        }
    }
}