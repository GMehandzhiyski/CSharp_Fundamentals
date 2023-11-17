namespace _03.SoftUniBarIncome
{
    internal class IncomeInfo
    {
        private string name;
        private string product;
        private int quantity;
        private decimal price;

        public IncomeInfo(string name, string product, int quantity, decimal price)
        {
            this.name = name;
            this.product = product;
            this.quantity = quantity;
            this.price = price;
        }
    }
}