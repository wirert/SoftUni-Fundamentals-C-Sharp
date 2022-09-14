using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCars = int.Parse(Console.ReadLine());

            var listCars = new List<Car>();

            AddCarsToList(numCars, listCars);

            string command = null;

            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] tokens = command.Split(" : ");
                string carName = tokens[1];

                Car curCar = listCars.First(car => car.Name == carName);

                switch (tokens[0])
                {
                    case "Drive":

                        DriveCar(tokens, curCar, listCars);

                        break;
                    case "Refuel":

                        RefuelCar(tokens, curCar);

                        break;
                    case "Revert":

                        RevertMileage(tokens, curCar);

                        break;
                }
            }

            foreach (var car in listCars)
            {
                Console.WriteLine(car);
            }
        }

        private static void AddCarsToList(int numCars, List<Car> listCars)
        {
            for (int i = 0; i < numCars; i++)
            {
                string[] input = Console.ReadLine().Split('|');

                listCars.Add(new Car(input[0], int.Parse(input[1]), int.Parse(input[2])));
            }
        }

        private static void DriveCar(string[] tokens, Car curCar, List<Car> listCars)
        {
            int distance = int.Parse(tokens[2]);
            int neededFuel = int.Parse(tokens[3]);


            if (curCar.Fuel < neededFuel)
            {
                Console.WriteLine("Not enough fuel to make that ride");
                return;
            }

            curCar.Mileage += distance;
            curCar.Fuel -= neededFuel;

            Console.WriteLine($"{curCar.Name} driven for {distance} kilometers. {neededFuel} liters of fuel consumed.");

            if (curCar.Mileage < 100000) return;

            listCars.Remove(curCar);
            Console.WriteLine($"Time to sell the {curCar.Name}!");
        }

        private static void RefuelCar(string[] tokens, Car curCar)
        {
            int fuel = int.Parse(tokens[2]);

            if (curCar.Fuel + fuel >= 75)
            {
                fuel = 75 - curCar.Fuel;
                curCar.Fuel = 75;
            }
            else
            {
                curCar.Fuel += fuel;
            }

            Console.WriteLine($"{curCar.Name} refueled with {fuel} liters");
        }

        private static void RevertMileage(string[] tokens, Car curCar)
        {
            int kilometers = int.Parse(tokens[2]);

            if (curCar.Mileage - kilometers < 10000)
            {
                curCar.Mileage = 10000;
            }
            else
            {
                curCar.Mileage -= kilometers;
                Console.WriteLine($"{curCar.Name} mileage decreased by {kilometers} kilometers");
            }
        }
    }

    class Car
    {
        public Car(string name, int mileage, int fuel)
        {
            Name = name;
            Mileage = mileage;
            Fuel = fuel;
        }

        public string Name { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }

        public override string ToString() => $"{Name} -> Mileage: {Mileage} kms, Fuel in the tank: {Fuel} lt.";

    }
}
