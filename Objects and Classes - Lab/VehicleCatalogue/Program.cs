using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            string input;

            while((input = Console.ReadLine()) != "end")
            {
                string[] inputData = input.Split('/', StringSplitOptions.RemoveEmptyEntries);

                string type = inputData[0];
                string brand = inputData[1];
                string model = inputData[2];

                if(type == "Truck")
                {
                    double weight = double.Parse(inputData[3]);

                    Truck truck = new Truck(brand, model, weight);
                    catalog.Trucks.Add(truck);
                }
                else if(type == "Car")
                {
                    int horsePower = int.Parse(inputData[3]);

                    Car car = new Car(brand, model, horsePower);
                    catalog.Cars.Add(car);
                }
            }

            Console.WriteLine("Cars:");

            foreach (Car car in catalog.Cars.OrderBy(c => c.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            Console.WriteLine("Trucks:");

            foreach (Truck truck in catalog.Trucks.OrderBy(t => t.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }

    public class Truck
    {
        public Truck(string brand, string model, double weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }
    }

    public class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    public class Catalog
    {
        public Catalog()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}
