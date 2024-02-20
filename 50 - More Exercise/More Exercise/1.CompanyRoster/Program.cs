namespace _1.CompanyRoster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberEmployees = int.Parse(Console.ReadLine());
            List<Employee> listEmployees = new List<Employee>();

            for (int i = 0; i < numberEmployees; i++)
            {
                string[] arguments = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = arguments[0];
                decimal salary = decimal.Parse(arguments[1]);
                string departament = arguments[2];

                Employee employee = new Employee(name, salary, departament);
                listEmployees.Add(employee);

            }

            for (int i = 0; i < listEmployees.Count; i++)
            {
                foreach (var currDepart in listEmployees)
                {
                    decimal averageSalary= listEmployees
                        .Where(c => c.Departament == c.Departament)
                        .Average(currDepart => currDepart.Salary);
                    Console.WriteLine(averageSalary);
                }
            }

           

        }
    }
    public class Employee
    {
        public Employee(string name, decimal salaty, string departament)
        {
            Name = name;
            Salary = salaty;
            Departament = departament;
        }

        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Departament { get; set; }
    }
}