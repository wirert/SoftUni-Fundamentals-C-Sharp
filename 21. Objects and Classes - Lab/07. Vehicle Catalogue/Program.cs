using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Catalogue catalogue = new Catalogue();

            while (command != "end")
            {
                string[] tokens = command.Split('/');

                switch (tokens[0])
                {
                    case "Car":
                        Car car = new Car
                        {
                            Brand = tokens[1],
                            Model = tokens[2],
                            HorsePower = int.Parse(tokens[3])
                        };
                        catalogue.Cars.Add(car);
                        break;
                    case "Truck":
                        Truck truck = new Truck
                        {
                            Brand = tokens[1],
                            Model = tokens[2],
                            Weight = int.Parse(tokens[3])
                        };
                        catalogue.Trucks.Add(truck);
                        break;
                }

                command = Console.ReadLine();
            }

            if (catalogue.Cars.Count > 0)
            {
                List<Car> orderedCars = catalogue.Cars.OrderBy(car => car.Brand).ToList();

                Console.WriteLine("Cars:");
                foreach (var car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalogue.Trucks.Count <= 0) return;
            {
                List<Truck> orderedTrucks = catalogue.Trucks.OrderBy(truck => truck.Brand).ToList();

                Console.WriteLine("Trucks:");
                foreach (var truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Catalogue
    {
        public Catalogue()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}
