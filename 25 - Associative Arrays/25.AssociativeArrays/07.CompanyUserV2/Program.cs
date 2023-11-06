namespace _07.CompanyUsers
{
    public class Program
    {
        static void Main(string[] args)
        {
            //List<string> employeesId = new List<string>();
            var companiesDataBase = new Dictionary <string, List<string>>();

            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "End")
            {
                List<string> commands = arguments
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string companyName = commands[0];
                string employeeId = commands[1];


                if (!companiesDataBase.ContainsKey(companyName))
                {

                    companiesDataBase.Add(companyName, new List<string>());
                    companiesDataBase[companyName].Add(employeeId);
                }
                else
                {
                    if (companiesDataBase[companyName].Any(x => x == employeeId))
                    {
                        continue;
                    }

                    companiesDataBase[companyName].Add(employeeId);    
                }
               

            }

            PrintCompanyDataBase(companiesDataBase);
        }

        private static void PrintCompanyDataBase(Dictionary <string, List<string>>  companiesDataBase)
        {
            foreach (KeyValuePair<string, List<string>> currCompany in companiesDataBase)
            {
                Console.WriteLine(currCompany.Key);

                foreach (string currEmployee in currCompany.Value)
                {
                        Console.WriteLine($"-- { string.Join("", currEmployee)}");
                }
            }
        }
    }
    
}