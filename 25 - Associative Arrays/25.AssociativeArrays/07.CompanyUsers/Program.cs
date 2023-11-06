namespace _07.CompanyUsers
{
    public class Program
    {
        static void Main(string[] args)
        {
            //List<string> employeesId = new List<string>();
            Dictionary <string, Company > companiesDataBase = new Dictionary<string, Company > ();

            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "End" ) 
            {
                List <string> commands = arguments
                    .Split(" -> ",StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string companyName = commands[0];
                string employeeId = commands[1];

                Company company = new Company(companyName, employeeId);

                if (!companiesDataBase.ContainsKey(companyName)) 
                {

                    companiesDataBase.Add(company.CompanyName, company);
                }
                else 
                {
                    companiesDataBase[company.EmployeeID].AddNewEmploeeId(employeeId);
                }
               
            }
           
            PrintCompanyDataBase(companiesDataBase);
        }

        private static void PrintCompanyDataBase(Dictionary<string, Company> companiesDataBase)
        {
            foreach (KeyValuePair<string, Company> currCompany in companiesDataBase)
            {
                Console.WriteLine(currCompany.Value.CompanyName);

                foreach (var currEmployee in companiesDataBase)
                {
                    if(currEmployee.Value.CompanyName == currCompany.Value.CompanyName )
                    {
                        Console.WriteLine(currEmployee.Value.EmployeeID);
                    }
                    
                }
            }
        }
    }
    public class Company
    {
        public Company(string companyName, string employeeId)
        {
            CompanyName = companyName;
            EmployeeID = employeeId;
        }

        public string CompanyName { get; set; }

        public string EmployeeID { get; set; }

        public void AddNewEmploeeId(string employeeId)
        {
            //EmployeeID.Add(employeeId);


        }

    }
}