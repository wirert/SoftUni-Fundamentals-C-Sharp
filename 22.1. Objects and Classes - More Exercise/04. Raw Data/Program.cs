using System;
using System.Collections.Generic;

namespace _04._Raw_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numCars; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                Car car = new Car(input[0], int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3]), input[4]);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            List<Car> carsNeeded = CarNeeded(command, cars);

            foreach (var car in carsNeeded)
            {
                Console.WriteLine(car.Model);
            }
        }

        static List<Car> CarNeeded(string command, List<Car> cars) => command == "fragile"
            ? cars.FindAll(car => car.Cargo.Type == command && car.Cargo.Weight < 1000)
            : cars.FindAll(car => car.Cargo.Type == command && car.Engine.Power > 250);

    }

    class Car
    {
        public Car(string model, int speed, int power, int weight, string type)
        {
            this.Model = model;
            this.Engine = new Engine(speed, power);
            this.Cargo = new Cargo(weight, type);
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
    }

    class Engine
    {
        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }
        public int Speed { get; set; }
        public int Power { get; set; }
    }

    class Cargo
    {
        public Cargo(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }
        public int Weight { get; set; }
        public string Type { get; set; }
    }
}
