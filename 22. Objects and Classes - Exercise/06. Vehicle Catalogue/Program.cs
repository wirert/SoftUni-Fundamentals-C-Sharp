using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] vehicleInfo = command.Split(" ");
                Vehicle vehicle = new Vehicle(vehicleInfo[0], vehicleInfo[1], vehicleInfo[2], int.Parse(vehicleInfo[3]));

                catalogue.Add(vehicle);

                command = Console.ReadLine();
            }

            string info = Console.ReadLine();

            while (info != "Close the Catalogue")
            {
                Vehicle seekVehicle = catalogue.FirstOrDefault(x => x.Model == info);
                Console.WriteLine(seekVehicle);

                info = Console.ReadLine();
            }

            double avCarHorsePower = 0;
            double avTruckHorsePower = 0;
            int count = 0;

            foreach (var vehicle in catalogue)
            {
                if (vehicle.Type == "car")
                {
                    avCarHorsePower += vehicle.Horsepower;
                    count++;
                }
                else
                    avTruckHorsePower += vehicle.Horsepower;
            }

            if (count != 0)
                avCarHorsePower /= count * 1.0;

            Console.WriteLine($"Cars have average horsepower of: {avCarHorsePower:f2}.");

            if (count != catalogue.Count)
                avTruckHorsePower /= (catalogue.Count - count) * 1.0;

            Console.WriteLine($"Trucks have average horsepower of: {avTruckHorsePower:f2}.");
        }
    }

    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsePower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public override string ToString()
        {
            var strBuild = new StringBuilder();
            strBuild.AppendLine($"Type: {char.ToUpper(Type[0]) + Type.Substring(1)}");
            strBuild.AppendLine($"Model: {Model}");
            strBuild.AppendLine($"Color: {Color}");
            strBuild.AppendLine($"Horsepower: {Horsepower}");

            return strBuild.ToString().TrimEnd();
        }
    }
}
