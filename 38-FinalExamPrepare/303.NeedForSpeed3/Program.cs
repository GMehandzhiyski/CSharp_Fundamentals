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

                if (command == "Drive")
                {
                    string currCar = currCommand[1];
                    int currDistance = int.Parse(currCommand[2]);
                    int currFuel = int.Parse(currCommand[3]);

                    bool isHaveFueltoTrip = CheckFuelLevel(currCar, currFuel, carsList);
                    if (isHaveFueltoTrip)
                    {
                        ReduceCarFuel(currCar, currDistance, currFuel, carsList);
                        CheckCarMileage(currCar, carsList);
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }



                }
                else if (command == "Refuel")
                {
                    string currCar = currCommand[1];
                    int currFuel = int.Parse(currCommand[2]);
                    RefuelCar(currCar, currFuel, carsList);

                }
                else if (command == "Revert")
                {
                    string currCar = currCommand[1];
                    int currKilometers = int.Parse(currCommand[2]);
                    RevertCar(currCar, currKilometers, carsList);
                    Console.WriteLine($"{currCar} mileage decreased by {currKilometers} kilometers");
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

        private static void RevertCar(string currCarModel, int currKilometers, List<Car> carsList)
        {
            Car currentCar = carsList.Where(c => c.Model == currCarModel).FirstOrDefault();

            if(currentCar != null)
            {
                currentCar.Mileage -= currKilometers;
            }
            if(currentCar.Mileage < 10000)
            {
                currentCar.Mileage = 10000;
            }
        }

        private static void RefuelCar(string currCar, int currFuel, List<Car> carsList)
        {
            Car currentCar = carsList.Where(c => c.Model == currCar).FirstOrDefault();

                if (currentCar.Model == currCar)
                {
                    int totalFuel = currentCar.Fuel + currFuel;

                    if (totalFuel > 75)
                    {
                           Console.WriteLine($"{currCar} refueled with {75 - currentCar.Fuel} liters");
                           currentCar.Fuel = 75;
                        
                        return;
                    }
                    else
                    {
                        currentCar.Fuel = totalFuel;
                        Console.WriteLine($"{currCar} refueled with {currFuel} liters");
                        return;

                    }
                }
            
           
        }

        // няма ли начин да изтрия директно с името(без ламбда)????????????????????????
        public static void CheckCarMileage(string currCar, List<Car> carsList)
        {

            Car currentCar = carsList.Where(c => c.Model == currCar).FirstOrDefault();

                if (currentCar.Model == currCar
                    && currentCar.Mileage >= 100000)
                {
                    carsList.Remove(currentCar);
                    Console.WriteLine($"Time to sell the {currCar}!");
                    return;
                }
 
        }

        public static bool CheckFuelLevel(string currCar, int currFuel, List<Car> carsList)
        {
            bool isHaveFueltoTrip = false;

            Car currentCar = carsList.Where(c => c.Model == currCar).FirstOrDefault() ;

            if (currentCar.Model == currCar
                && currentCar.Fuel >= currFuel)
            {
                isHaveFueltoTrip = true;
            }


            return isHaveFueltoTrip;
        }

        public static void ReduceCarFuel(string currCar, int currDistance, int currFuel, List<Car> carsList)
        {

            Car curruentCar = carsList.Where(c => c.Model == currCar).FirstOrDefault();   

                if (curruentCar.Model == currCar)
                {
                    curruentCar.Fuel -= currFuel;
                    curruentCar.Mileage += currDistance;
                    Console.WriteLine($"{curruentCar.Model} driven for {currDistance} kilometers. {currFuel} liters of fuel consumed.");
                    return;
                }

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