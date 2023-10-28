using System.Runtime.CompilerServices;

namespace _07.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>();
            List<Truck> truckList = new List<Truck>();

            string arguments;
            while ((arguments = Console.ReadLine()) != "end")
            {
               

                List<string> argumetsList = arguments
                    .Split("/", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string type = argumetsList[0];
                string brand = argumetsList[1];
                string model = argumetsList[2];
                string horseWeight = argumetsList[3];

                if (type == "Car")
                {
                   Car car = new Car(brand, model, horseWeight);
                   carList.Add(car);

                }
                else if (type == "Truck")
                {
                    Truck truck = new Truck(brand, model, horseWeight);
                    truckList.Add(truck);
                }
                

            }
            if (carList.Count > 0 ) 
            {
                Console.WriteLine("Cars:");
                foreach (Car car in carList.OrderBy(c => c.Brand)) 
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp ");
                }
            }
            if (truckList.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in truckList.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg"); 
                }

            }

        }
    }
    class Truck
    {
      
        public Truck(string brand, string model, string horseWeight)
        {
            Brand = brand;
            Model = model;
            Weight = horseWeight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }
    class Car
    {

        public Car(string brand, string model, string horseWeight)
        {
            Brand = brand;
            Model = model;
            HorsePower = horseWeight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }
    //class CatalogVehicle
    //{


    //    public CatalogVehicle(string type, string brand, string model, string horsePower)
    //    {
    //        B = type;
    //        brand = brand;
    //        model = model;
    //        horsePower = horsePower;
    //    }

    //    public List<Truck> Truck { get; set; }
    //    public List<Car> Cars { get; set; }
    //}
}