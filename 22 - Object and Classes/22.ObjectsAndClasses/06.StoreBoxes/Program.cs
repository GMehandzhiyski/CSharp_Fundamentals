namespace _06.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> ListBoxs = new List<Box>();

            string arguments;
            while ((arguments = Console.ReadLine()) != "end")
            {
                List<string> inpusListBoxes = arguments
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                int boxSerialNumber = int.Parse(inpusListBoxes[0]);
                string boxItemName = inpusListBoxes[1];
                int boxQuantity = int.Parse(inpusListBoxes[2]);
                decimal boxPrice = decimal.Parse(inpusListBoxes[3]);

                Item item = new Item(boxItemName, boxPrice);
                Box box = new Box(boxSerialNumber, item, boxQuantity);

                ListBoxs.Add(box);
 
            }
                
            foreach (Box box in ListBoxs.OrderByDescending(l => l.PricesBox)) 
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PricesBox:f2}");
            }



        }
    }
    class Item
    {
        public Item(string boxItemName, decimal boxPrice)
        { 
            Name = boxItemName;
            Price = boxPrice;
        }
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
    class Box
    {

        public Box(int boxSerialNumber, Item item, int boxQuantity)
        {
            SerialNumber = boxSerialNumber;
            Item = item;
            ItemQuantity = boxQuantity;
                
        }

        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PricesBox => Item.Price * ItemQuantity;

    }
}
