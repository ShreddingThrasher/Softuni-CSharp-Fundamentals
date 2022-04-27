using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            string input;

            while((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string type = command[0];
                string model = command[1];
                string color = command[2];
                int horsePower = int.Parse(command[3]);

                Vehicle vehicle = new Vehicle(type, model, color, horsePower);

                vehicles.Add(vehicle);
            }

            string information;

            while((information = Console.ReadLine()) != "Close the catalogue")
            {
                Vehicle vehicle = vehicles.Find(v => v.Model == information);
                Console.WriteLine(vehicle);
            }

            double averageCarsHp = vehicles.Where(v => v.Type == "Car")
                                            .Select(v => v.HorsePower)
                                            .Average();

            double averageTrucksHp = vehicles.Where(v => v.Type == "Truck")
                                            .Select(v => v.HorsePower)
                                            .Average();

            Console.WriteLine($"Cars have average horsepower of {averageCarsHp:F2}.");
            Console.WriteLine($"Trucks have average horsepower of {averageTrucksHp:F2}.");
        }
    }
    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Type: {this.Type}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Color: {this.Color}");
            sb.AppendLine($"Horsepower: {this.HorsePower}");

            return sb.ToString().TrimEnd();
        }
    }
}
