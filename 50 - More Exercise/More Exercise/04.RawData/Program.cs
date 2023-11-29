namespace _04.RawData
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int inputCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();   

            for (int i = 0; i < inputCars; i++)
            {
                string[] argumets = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = argumets[0];
                

                int engineSpeed = int.Parse(argumets[1]);
                int enginePower = int.Parse(argumets[2]);
                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(argumets[3]);
                string cargoType = argumets[4];
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Car car = new Car(model, engine, cargo);
                cars.Add(car);  
            }

            string argumet = Console.ReadLine();

            if (argumet == "fragile")
            {
                foreach (var currCar in cars)
                {
                    if (currCar.Cargo.CargoType == "fragile"
                        && currCar.Cargo.CargoWeight < 1000)
                    {
                        Console.WriteLine(currCar.Model);
                    }
                }
            }
            else if (argumet == "flamable")
            {
                foreach (var currCar in cars)
                {
                    if (currCar.Cargo.CargoType == "flamable"
                        && currCar.Engine.EnginePower > 200)
                    {
                        Console.WriteLine(currCar.Model);
                    }
                }
            }
           
            
        }
    }
    public class Car
    {
        public Car(string model,Engine engine,Cargo cargo)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
        }
        public string Model { get; set; }

        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }



    }
    public class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
        }

        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }

    public class Cargo
    {
        private int cargoWeight;

        public Cargo(int cargoWeight, string cargoType)
        {
            CargoWeight = cargoWeight;
            CargoType = cargoType;
        }

        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }


}