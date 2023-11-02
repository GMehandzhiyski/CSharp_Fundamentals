using System;

/*
4
ChevroletExpress 215 255 1200 flamable
ChevroletAstro 210 230 1000 flamable
DaciaDokker 230 275 1400 flamable
Citroen2CV 190 165 1200 fragile
flamable

 
 
 
 */
namespace _03.SpeedRacing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfCar = int.Parse(Console.ReadLine());
            List<Car> carsList = new List<Car>();
            if (numberOfCar > 0)
            {

                for (int i = 0; i < numberOfCar; i++)
                {
                    List<string> argument = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                    decimal distanceTraveled = 0;
                    string model = argument[0];
                    decimal fuel = decimal.Parse(argument[1]);
                    decimal consumPerKm = decimal.Parse(argument[2]);
                    if (fuel < 0)
                    {
                        fuel = 0;
                    }

                    Car car = new Car(model, fuel, consumPerKm, distanceTraveled);
                    carsList.Add(car);

                }
                string arguments;
                while ((arguments = Console.ReadLine()) != "End")
                {

                    string[] commands = arguments
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    string carBrand = commands[1];
                    decimal amountOfKm = decimal.Parse(commands[2]);

                    Car curruentCar = null;
                    foreach (Car currCar in carsList)
                    {
                        if (currCar.Model == carBrand)
                        {

                            curruentCar = currCar;
                        }

                    }

                    bool canCarMove = curruentCar.CarCanMove(amountOfKm);

                    if (canCarMove)
                    {
                        curruentCar.MoveCar(amountOfKm);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }


                }

                PrintAllCars(carsList);

              


            }
            else
            {
                return;
            }


           
        }

        public class Car
        {


            public Car(string model, decimal fuel, decimal consumPerKm, decimal distanceTraveled)
            {
                Model = model;
                Fuel = fuel;
                ConsumPerKm = consumPerKm;
                DistanceTraveled = distanceTraveled;
                DistanceTraveled = distanceTraveled;
            }

            public string Model { get; set; }

            public decimal Fuel { get; set; }
            public decimal ConsumPerKm { get; set; }

            public decimal DistanceTraveled { get; set; }

            public bool CarCanMove(decimal amountOfKm)
            {
                if ((amountOfKm * ConsumPerKm) < Fuel)
                {
                    return true;
                }

                return false;
            }

            public void MoveCar(decimal amountOfKm)
            {
                Fuel -= amountOfKm * ConsumPerKm;
                DistanceTraveled += amountOfKm;
                if (Fuel < 0)
                { 
                 Fuel = 0;
                }

            }

        }


        public static void PrintAllCars(List<Car> carsList)
        {
            foreach (Car cars in carsList)
            {
                Console.WriteLine($"{cars.Model} {cars.Fuel:f2} {cars.DistanceTraveled}");
            }
        }
    }

     
}