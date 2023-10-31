namespace _201.CompanyRoster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int numberPerLines = int.Parse(Console.ReadLine());
            List<Employee> employeesList = new List<Employee>();

            for (int i = 0; i < numberPerLines; i++)
            {
                List<string> argumentsList = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string name = argumentsList[0];
                decimal salary = decimal.Parse(argumentsList[1]);
                string departament = argumentsList[2];

                Employee employee = new Employee(name, salary, departament);
                employeesList.Add(employee);

            }

            decimal maxAverageDepartamentSalaty = 0;
            foreach (Employee employeeSalary in employeesList)
            {

   





                decimal totalEmployeeSalary = 0;
                int countDepartament = 0;
               
                    totalEmployeeSalary += employeeSalary.Salary;
                    countDepartament++;
                
               
                
                decimal averageDepartamentSalary = totalEmployeeSalary / countDepartament;

                if (averageDepartamentSalary > maxAverageDepartamentSalaty)
                { 
                    maxAverageDepartamentSalaty = averageDepartamentSalary;
                }

            }


        }
    }
    class Employee
    {
        public Employee(string name, decimal salary, string departament)
        {
            Name = name;
            Salary = salary;
            Departament = departament;

        }
        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string Departament { get; set; }

    }
}