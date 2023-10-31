using System;

namespace _03.SpeedRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCar = int.Parse(Console.ReadLine());
            List <Car> carsList = new List<Car>();

            for (int i = 0; i < numberOfCar; i++) 
            {
                List<string> argument = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string model = argument[0];
                decimal fuel = decimal.Parse(argument[1]);
                decimal consumPerKm = decimal.Parse(argument[2]);

                Car car = new Car(model, fuel, consumPerKm);
                carsList.Add(car);  

            }
            string arguments;
            while ((arguments = Console.ReadLine()) != "End")
            {

                string[] commands = arguments
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string car = commands[1];
                decimal amountOfKm = decimal.Parse(commands[2]);
                bool isCarCanMove = Car.CarCanMove(car, amountOfKm, carsList);
            
            
            }
         
            
        }
    }
    class Car
    {

        internal static bool CarCanMove(string car, decimal amountOfKm, List <Car> carsList)
        {
            if ()
            {

            }
            return;
        }

        public Car(string model, decimal fuel, decimal consumPerKm)
        {
            Model = model;
            Fuel = fuel;
            ConsumPerKm = consumPerKm;
        }

        public string Model { get; set; }

        public decimal Fuel { get; set; }
        public decimal ConsumPerKm { get; set; }

    }
}