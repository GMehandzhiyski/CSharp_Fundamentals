using System.Reflection;

namespace _3.SpeedRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCars = int.Parse( Console.ReadLine());
            List<Car> cars = new List<Car>();   
            for (int i = 0; i < numberCars; i++)
            {
                string[] argumnets = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = argumnets[0];
                decimal fuel = decimal.Parse( argumnets[1]);
                decimal consumation = decimal.Parse(argumnets[2]);

                Car car = new Car(model, fuel, consumation);
                cars.Add(car);  
            }

            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "End")
            {

                string[] commands = arguments
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

               string carModel = commands[1];
               decimal amount = decimal.Parse(commands[2]);

               Car currCar = cars.Where(c => c.Model == carModel).FirstOrDefault();

                bool isCarCanMove = MoveCar(currCar, carModel, amount, cars);
                if ( isCarCanMove)
                {
                    ResuceCarFuelAndDistance(currCar, amount, cars);
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            foreach (var currCar in cars)
            {
                Console.WriteLine($"{currCar.Model} {currCar.Fuel:f2} {currCar.TraveledDistance}");
            }
        }

        private static void ResuceCarFuelAndDistance(Car currCar, decimal amount, List<Car> cars)
        {
           currCar.Fuel -= currCar.Consumation * amount;
           currCar.TraveledDistance += amount;
        }

        public static bool MoveCar(Car currCar, string carModel, decimal amount, List<Car> cars)
        {
            bool isCarCanMove = false;
          
            if (currCar.Fuel >= (currCar.Consumation * amount))
            {
                isCarCanMove = true;
            }
            return isCarCanMove;
        }

    }
    public class Car
    {
        public Car(string model, decimal fuel, decimal consumation)
        {
            Model = model;
            Fuel = fuel;    
            Consumation = consumation;   
        }

        public string Model { get; set; }
        public decimal Fuel { get; set; }
        public decimal Consumation { get; set; }
        public decimal TraveledDistance { get; set; } 
    }
}