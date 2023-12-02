namespace _803.NeedforSpeedIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] argumets = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string carName = argumets[0];
                int mileAge = int.Parse(argumets[1]);
                int fuel = int.Parse(argumets[2]);

                Car car = new Car(carName, mileAge, fuel);
                cars.Add(car);

            }
            string arguments = String.Empty;
            while ((arguments = Console.ReadLine()) != "Stop")
            {
                string[] commands = arguments
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = commands[0];
                string car = commands[1];

                bool isCarIsValid = CheckValidCar(cars, car);
                if (!isCarIsValid)
                {
                    continue;
                }
                if (command == "Drive")
                {
                    int distance = int.Parse(commands[2]);
                    int fuel = int.Parse(commands[3]);
                    bool isHaveFuel = CheckAvailаbleFuel(cars, car, fuel);
                    if (isHaveFuel)
                    {
                        CarIsTarvel(cars, car, distance, fuel);
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }

                    bool isTimeToSellCar = ChechCarMileAge(cars, car);
                    if (isTimeToSellCar)
                    {
                        DeleteCar(cars, car);
                        Console.WriteLine($"Time to sell the {car}!");
                    }
                }
                else if (command == "Refuel")
                {
                    int fuel = int.Parse(commands[2]);
                    RefuelCar(cars, car, fuel);

                }
                else if (command == "Revert")
                {
                    int kilometers = int.Parse(commands[2]);
                    DecreaseMileage(cars, car, kilometers);
                }
                else
                {
                    continue;
                }

            }

            PrintFinalResult(cars);
        }

        private static void PrintFinalResult(List<Car> cars)
        {
            foreach (var currCar in cars)
            {
                Console.WriteLine($"{currCar.CarName} -> Mileage: {currCar.MileAge} kms, Fuel in the tank: {currCar.Fuel} lt.");
            }
        }

        private static void DecreaseMileage(List<Car> cars, string car, int kilometers)
        {
            foreach (var currCar in cars)
            {
                if (currCar.CarName == car)
                {
                    currCar.MileAge -= kilometers;
                    if (currCar.MileAge < 10000)
                    {
                        currCar.MileAge = 10000;
                    }
                    else 
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");// problem ??? kilometers
                    }

                    
                }
            }
        }

        private static void RefuelCar(List<Car> cars, string car, int fuel)
        {   int aditionalFuel = 0;
            foreach (var currCar in cars)
            {
                if (currCar.CarName == car)
                {
                    aditionalFuel = 75 - currCar.Fuel;
                    currCar.Fuel += fuel;
                    
                    if (currCar.Fuel >= 75)
                    {
                        currCar.Fuel = 75;
                        Console.WriteLine($"{currCar.CarName} refueled with {aditionalFuel} liters");
                    }
                    else
                    {
                        
                        Console.WriteLine($"{currCar.CarName} refueled with {fuel} liters");
                    }
                    break;
                }
            }
        }

        private static bool CheckValidCar(List<Car> cars, string car)
        {
            bool isCarIsValid = false;
            foreach (var currCar in cars)
            {
                if (currCar.CarName == car)
                {
                    return isCarIsValid = true;
                }
            }
            return isCarIsValid;
        }

        private static void DeleteCar(List<Car> cars, string car)
        {
            foreach (var currCar in cars)
            {
                if (currCar.CarName == car)
                {
                    cars.Remove(currCar);
                    break;
                }
            }
        }

        private static bool ChechCarMileAge(List<Car> cars, string car)
        {
            bool isTimeToSellCar = false;
            foreach (var currCar in cars)
            {
                if (currCar.CarName == car
                    && currCar.MileAge >= 100000)
                {
                    return isTimeToSellCar = true;
                }
            }
            return isTimeToSellCar;
        }

        private static void CarIsTarvel(List<Car> cars, string car, int distance, int fuel)
        {
            foreach (var currCar in cars)
            {
                if (currCar.CarName == car)
                {
                    currCar.MileAge += distance;
                    currCar.Fuel -= fuel;
                    break;
                }
            }
        }

        private static bool CheckAvailаbleFuel(List<Car> cars, string car, int fuel)
        {
            bool isHaveFuel = false;
            foreach (var currCar in cars)
            {
                if (currCar.CarName == car
                    && currCar.Fuel >= fuel)
                {
                    return isHaveFuel = true;
                }
            }
            return isHaveFuel;
        }
    }
    public class Car
    {
        public Car(string carName, int mileAge, int fuel)
        {
            CarName = carName;
            MileAge = mileAge;
            Fuel = fuel;
        }

        public string CarName { get; set; }
        public int MileAge { get; set; }
        public int Fuel { get; set; }
    }
}