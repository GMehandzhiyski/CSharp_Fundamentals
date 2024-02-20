using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace _07.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalog vehicles = new Catalog();

            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "end")
            {
                string[] argument = arguments
                    .Split("/", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string type = argument[0];
                string brand = argument[1];
                string model = argument[2];
                string powerWeight = argument[3];

                if (type == "Car")
                {
                    Car car = new Car(brand, model, powerWeight);
                    vehicles.Car.Add(car);
                }
                else if (type == "Truck")
                {
                    Truck truck = new Truck(brand, model, powerWeight);
                    vehicles.Truck.Add(truck);
                }

                
            }

            Console.WriteLine("Cars:");
            foreach (var currCar in vehicles.Car.OrderBy(v => v.Brand))
            {
               
                Console.WriteLine($"{currCar.Brand}: {currCar.Model} - {currCar.HoresePower}hp");
            }

            Console.WriteLine("Trucks:");
            foreach (var currTruck in vehicles.Truck.OrderBy(v => v.Brand))
            {

                Console.WriteLine($"{currTruck.Brand}: {currTruck.Model} - {currTruck.Weight}kg");
            }
        }
    }
    public class Catalog
    {
        public Catalog()
        {
            Car = new List<Car>();
            Truck = new List<Truck>();
        }

        public List <Car> Car { get; set; }
        public List <Truck> Truck { get; set; }

    }

    public class Car
    {
        public Car(string brand, string model, string powerWeight)
        {
            Brand = brand;
            Model = model;
            HoresePower = powerWeight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string HoresePower { get; set; }
    }
    public class Truck
    {

        public Truck(string brand, string model, string powerWeight)
        {
            Brand = brand;
            Model = model;
            Weight = powerWeight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }
}