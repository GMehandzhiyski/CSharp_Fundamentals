﻿namespace _106.VehicleCatalogue
{
/*
truck Volvo blue 0
truck Man red 0
car Tesla silver 0
car Nio red 0
truck Mack white 0
car Koenigsegg orange 0
End
Tesla
Nio
Man
Mack
Close the Catalogue







    */
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehiclelist = new List<Vehicle>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string type = arguments[0];
                string model = arguments[1];
                string color = arguments[2];
                decimal horsePower = decimal.Parse(arguments[3]);

                Vehicle vehicle = new Vehicle(type, model, color, horsePower);
                vehiclelist.Add(vehicle);

            }

            while ((command = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (Vehicle vehicle in vehiclelist)
                {
                    if (vehicle.Model == command)
                    {
                        Console.WriteLine($"Type: {vehicle.Type}\n " +
                            $"Model: {vehicle.Model}\n " +
                            $"Color: {vehicle.Color}\n " +
                            $"Horsepower: {vehicle.HorsePower}");
                    }

                }

            }
            decimal averageHPCar = 0;
            int carCount = 0;
            foreach (var vehicle in vehiclelist)
            {
                if (vehicle.Type == "Car")
                {
                    averageHPCar += vehicle.HorsePower;
                    carCount++;
                }
            }

            decimal averageHPTruck = 0;
            int truckCount = 0;
            foreach (var vehicle in vehiclelist)
            {
                if (vehicle.Type == "Truck")
                {
                    averageHPTruck += vehicle.HorsePower;
                    truckCount++;
                }


            }

            Console.WriteLine($"Cars have average horsepower of: {(averageHPCar / carCount):f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {(averageHPTruck / truckCount):f2}.");
        }
    }
    class Vehicle
    {


        public Vehicle(string typeInput, string model, string color, decimal horsePower)
        {
            Type = typeInput;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        private string type;

        public string Type
        {
            get 
            {
                return type;
            }
            set 
            {
                type = Capitalize(value);
            }
        }
        public string Model { get; set; }

        public string Color { get; set; }

        public decimal HorsePower { get; set; }

        public string Capitalize(string value)
        {
            char[] charArray = value.ToCharArray();
            if (char.IsLower(charArray[0]))
            {
                charArray[0] = char.ToUpper(charArray[0]);
            }

            return new string(charArray);
        }

    }
}