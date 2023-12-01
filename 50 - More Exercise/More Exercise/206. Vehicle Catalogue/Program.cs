using System;
using System.Security.Cryptography.X509Certificates;

namespace _206._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            Catalog catalog = new Catalog();

            string argumets = string.Empty;
            while ((argumets = Console.ReadLine()) != "End")
            {
                string[] argumet = argumets 
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string type = argumet[0];
                string model = argumet[1];
                string color = argumet[2];
                int horsePower =int.Parse( argumet[3]);

                if (type == "car")
                {
                    Car car = new Car(type, model, color, horsePower);
                    catalog.Car.Add(car);
                }
                else if (type == "truck")
                {
                    Truck truck = new Truck(type, model, color, horsePower);
                    catalog.Truck.Add(truck);
                }
            }

            Console.WriteLine("end");
        }
    }
    public class Catalog
    {
        public Catalog()
        {
            Car = new List<Car>();
            Truck = new List<Truck>();
        }
        public List<Car> Car { get; set; }
        public List<Truck> Truck { get; set; }

    }
    public class Car
    {

        public Car(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }
    public class Truck
    {
        public Truck(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }


}