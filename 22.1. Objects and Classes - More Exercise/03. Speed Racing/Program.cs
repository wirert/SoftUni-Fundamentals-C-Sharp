using System;
using System.Collections.Generic;

namespace _03._Speed_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                var inputCar = Console.ReadLine().Split();
                Car car = new Car(inputCar[0], double.Parse(inputCar[1]), double.Parse(inputCar[2]));
                cars.Add(car);
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                string modelCar = command[1];
                int distanceToTravel = int.Parse(command[2]);

                Car car = cars.Find(car => car.Model == modelCar).MovingOrNotCar(distanceToTravel);
                
                command = Console.ReadLine().Split();
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }

    class Car
    {
        public Car(string model, double fuel, double consumption)
        {
            this.Model = model;
            this.FuelAmount = fuel;
            this.Consumption = consumption;
            this.DistanceTraveled = 0;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double Consumption { get; set; }
        public int DistanceTraveled { get; set; }

        public Car MovingOrNotCar(int distanceToTravel)
        {
            double fuelNeeded = distanceToTravel * Consumption;

            if (FuelAmount < fuelNeeded)
            {
                Console.WriteLine("Insufficient fuel for the drive");
                return this;
            }
            
            FuelAmount -= fuelNeeded;
            DistanceTraveled += distanceToTravel;
            return this;
        }

        public override string ToString()
        {
            return $"{Model} {FuelAmount:f2} {DistanceTraveled}";
        }
    }
}
