using System.Collections.Generic;

namespace _303.NeedForSpeed3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> carsList = new List<Car>();

            //Add every current car in Car list
            for (int i = 0; i < numberOfCars; i++)
            {

                string[] currCar = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string currModel = currCar[0];
                int currMileAge = int.Parse(currCar[1]);
                int currFuel = int.Parse(currCar[2]);

                Car cars = new Car(currModel, currMileAge, currFuel);
                carsList.Add(cars);

            }

            // Receiving different command
            // This logic manipulate Car List

            string arguments;
            while ((arguments = Console.ReadLine()) != "Stop")
            {
                List<string> currCommand = arguments
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string command = currCommand[0];
                string currCar = currCommand[1];

                Car currentCar = carsList.Where(c => c.Model == currCar).FirstOrDefault();

                if (currentCar == null)
                {
                    continue;
                }

                if (command == "Drive")
                {

                    int currDistance = int.Parse(currCommand[2]);
                    int currFuel = int.Parse(currCommand[3]);

                    bool isHaveFueltoTrip = CheckFuelLevel(currFuel, currentCar);
                    if (isHaveFueltoTrip)
                    {
                        ReduceCarFuel(currDistance, currFuel, currentCar);
                        CheckCarMileage(currentCar,carsList);
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }



                }
                else if (command == "Refuel")
                {

                    int currFuel = int.Parse(currCommand[2]);
                    RefuelCar(currFuel, currentCar);

                }
                else if (command == "Revert")
                {
                    int currKilometers = int.Parse(currCommand[2]);
                    RevertCar(currKilometers, currentCar);
                    Console.WriteLine($"{currentCar.Model} mileage decreased by {currKilometers} kilometers");
                }
                else
                {
                    continue;
                }


            }

            foreach (var car in carsList)
            {
                Console.WriteLine($"{car.Model} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }




        }

        private static void RevertCar(int currKilometers, Car currentCar)
        {


            if (currentCar != null)
            {
                currentCar.Mileage -= currKilometers;
            }
            if (currentCar.Mileage < 10000)
            {
                currentCar.Mileage = 10000;
            }
        }

        private static void RefuelCar(int currFuel, Car currentCar)
        {
                int totalFuel = currentCar.Fuel + currFuel;

                if (totalFuel > 75)
                {
                    Console.WriteLine($"{currentCar.Model} refueled with {75 - currentCar.Fuel} liters");
                    currentCar.Fuel = 75;

                    return;
                }
                else
                {
                    currentCar.Fuel = totalFuel;
                    Console.WriteLine($"{currentCar.Model} refueled with {currFuel} liters");
                    return;

                }


        }

        // няма ли начин да изтрия директно с името(без ламбда)????????????????????????
        public static void CheckCarMileage(Car currentCar,List<Car> carsList)
        {


            if (currentCar.Mileage >= 100000)
            {
                Console.WriteLine($"Time to sell the {currentCar.Model}!");
                carsList.Remove(currentCar);
                
            }

        }

        public static bool CheckFuelLevel(int currFuel, Car currentCar)
        {

            return currentCar.Fuel >= currFuel;
        }

        public static void ReduceCarFuel(int currDistance, int currFuel, Car currentCar)
        {
            currentCar.Fuel -= currFuel;
            currentCar.Mileage += currDistance;
            Console.WriteLine($"{currentCar.Model} driven for {currDistance} kilometers. {currFuel} liters of fuel consumed.");
        }


    }
    public class Car
    {
        public Car(string model, int mileage, int fuel)
        {
            Model = model;
            Mileage = mileage;
            Fuel = fuel;
        }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
}