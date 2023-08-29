namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Input Value
           int lostGames = int.Parse(Console.ReadLine());
           double priceHeadset = double.Parse(Console.ReadLine());    
           double priceMouse = double.Parse(Console.ReadLine()); 
           double priceKeyboard = double.Parse(Console.ReadLine());
           double priceDisplay = double.Parse(Console.ReadLine());

            //Headset Trash
            double trashedHeadset = (lostGames / 2);
            //Mouse Trash
            double trashedMouse = (lostGames / 3);
            //Keyboard Trash
            double trashedKeyboard = (lostGames / 6);
            //Display Trash
            double trashedDisplay = (lostGames / 12);
            // 

            double totalHeadsetPrice = Math.Round(trashedHeadset) * priceHeadset;
            double totalMousePrice = Math.Round(trashedMouse) * priceMouse;
            double totalKeyboardPrice = Math.Round(trashedKeyboard) * priceKeyboard;
            double totalDisplayPrice = Math.Round(trashedDisplay) * priceDisplay;

            double generalSetPrice = totalHeadsetPrice + totalMousePrice + totalKeyboardPrice + totalDisplayPrice;


             /*
            Console.WriteLine(trashedHeadset);
            Console.WriteLine(trashedMouse);
            Console.WriteLine(trashedKeyboard);
            Console.WriteLine(trashedDisplay);
            */


            //Output Value
            Console.WriteLine($"Rage expenses: {generalSetPrice:f2} lv.");
        }
    }
}