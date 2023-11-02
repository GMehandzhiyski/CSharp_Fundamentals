using System;

namespace _204.RawData
{
    public class Program
    {
        static void Main(string[] args)
        {
           List <Car> carsList = new List <Car> ();
           //Engine engine = new Engine();
           //Cargo cargo = new Cargo();  

          int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                List <string> argument = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string model = argument[0];
                int engineSpeed = int.Parse(argument[1]);
                int enginePower = int.Parse(argument[2]);
                int cargoWeight = int.Parse(argument[3]);
                string cargoType = argument[4];

                

                Engine engine = new Engine (engineSpeed, enginePower);
  
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Car car = new Car(model, engine, cargo);

                carsList.Add (car);
               
            }

               string argumet = Console.ReadLine();
            if (argumet == "fragile")
            {
                foreach (Car car in carsList)
                {
                    if (car.Cargo.CargoType == "fragile"
                        && car.Cargo.CargoWeight < 1000)
                    {
                        Console.WriteLine(car.Model);
                    }
                }

            }
            else if (argumet == "flamable")
            {

                foreach (Car car in carsList)
                {
                    if (car.Cargo.CargoType == "flamable"
                        && car.Engine.EnginePower > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }

            }







             

        }
    }
   
    public class Engine
    {
        public Engine(int engineSpeed,int enginePower)
        {
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;

        }
        public int EngineSpeed { get; set; }

        public int EnginePower { get; set; }

      
    }

    public class Cargo
    {
        public Cargo(int cargoWeight, string cargoType)
        {
            CargoWeight = cargoWeight;
            CargoType = cargoType;
        }
        public int CargoWeight { get; set; }

        public string CargoType { get; set; }

     
    }
   public class Car
    {

        public Car(string model, Engine engine,Cargo cargo)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
           

        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public void PrintModel()
        {

            Console.WriteLine($"Model is : {Model}");
            Console.WriteLine($"{Engine.EnginePower}");
            Console.WriteLine($"{Cargo.CargoType}");
        }

    }
    
}