using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string pattern = @"\%(?<name>[A-Z][a-z]+)\%[^|'$%.]*\<(?<product>[A-Za-z]+)\>[^|'$%.]*\|(?<quantity>\d+)\|[^|'$%.]*?(?<price>\d+|\d+\.\d+)\$";
            string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
            List<IncomeInfo> listIncomeInfo = new List<IncomeInfo>();

            string argumets = string.Empty;
            while ((argumets = Console.ReadLine()) != "end of shift") 
            {
                MatchCollection matches = Regex.Matches(argumets, pattern);

                foreach (Match match in matches)
                {
                    string name = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["count"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);

                    IncomeInfo incomeInfo = new IncomeInfo(name, product, quantity, price);
                    listIncomeInfo.Add(incomeInfo); 
                }
            }

            PrintFinalIncomeInfo(listIncomeInfo);
        }

        private static void PrintFinalIncomeInfo(List<IncomeInfo> listIncomeInfo)
        {
            decimal totalPrice = 0;
            decimal totalIncome = 0;

            foreach (var item in listIncomeInfo)
            {  
                totalPrice = item.Price * item.Quantity;
                Console.WriteLine($"{item.Name:f2}: {item.Product:f2} - {totalPrice:f2}");
                totalIncome += totalPrice;
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }

        public class IncomeInfo
        {
            public IncomeInfo(string name, string product, int quantity, decimal price)
            {
                Name = name;
                Product = product;
                Quantity = quantity;    
                Price = price;  
                
            }
            public string Name { get; set; }
            public string Product { get; set; }

            public int Quantity { get; set; }

            public decimal Price  { get; set; }

        }
       
    }

}