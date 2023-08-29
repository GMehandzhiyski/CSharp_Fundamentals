namespace _09.PadawanEquipment
{
    public class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());    
            int studnets = int.Parse(Console.ReadLine()); 
            double priceLightsabers = double.Parse(Console.ReadLine()); 
            double priceRobes = double.Parse(Console.ReadLine());   
            double priceBelts = double.Parse(Console.ReadLine());

            double totalPriceLightsabers = 0;
            double totalPriceRobes = 0;
            double totalPriceBelts = 0;
            double totalLighsabresNumbers = 0;
            double freeBelts = 0;
            double generalPrice = 0;

            // lighsabres
            totalLighsabresNumbers = Math.Ceiling (studnets * 1.1) ;
            totalPriceLightsabers = (totalLighsabresNumbers * priceLightsabers);
            // Robes
            totalPriceRobes = studnets * priceRobes;
            //Belst
            freeBelts = (studnets / 6);
            totalPriceBelts = (studnets - freeBelts) * priceBelts;

            generalPrice = totalPriceLightsabers + totalPriceRobes + totalPriceBelts;


            if (generalPrice <= money )
            {
                Console.WriteLine($"The money is enough - it would cost {(generalPrice):F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need { Math.Abs(money - generalPrice):F2}lv more.");
            }

            



        }
    }
}