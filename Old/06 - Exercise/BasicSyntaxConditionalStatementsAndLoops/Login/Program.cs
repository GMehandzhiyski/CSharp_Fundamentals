using System;
using System.Diagnostics.Tracing;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            int counterPassword = 0;
            string passwordMirror = string.Empty;
            string passwordLast = string.Empty;

            for (int i = password.Length - 1; i >= 0; i--)
            {
                passwordMirror += password[i];
            }
            
            while ((passwordMirror != (passwordLast = Console.ReadLine())) && counterPassword < 3)
            {
                Console.WriteLine("Incorrect password. Try again.");
                counterPassword++;
            }

            if (passwordLast == passwordMirror)
            {
                Console.WriteLine($"User {password} logged in.");
            }
            else 
            {
                Console.WriteLine($"User {password} blocked!");
            }
            
        }
    }
}
