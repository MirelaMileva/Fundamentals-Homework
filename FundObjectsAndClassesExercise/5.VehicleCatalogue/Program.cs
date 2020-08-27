using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Vehicle> vehicles = new List<Vehicle>();

            while (input != "End")
            {
                string[] vehicleInfo = input.Split();
                Vehicle vehicle = new Vehicle(vehicleInfo[0], vehicleInfo[1], vehicleInfo[2], double.Parse(vehicleInfo[3]));
                vehicles.Add(vehicle);

                input = Console.ReadLine();
            }

            string model = Console.ReadLine();

            while (model != "Close the Catalogue")
            {
                Console.WriteLine(vehicles.FirstOrDefault(x => x.Model == model).ToString());

                model = Console.ReadLine();
            }

            var cars = vehicles.FindAll(car => car.Type == "car");
            var carsPower = cars.Sum(c => c.HorsePower);
            var averageCarPower = carsPower / cars.Count;
            if (cars.Count == 0)
            {
                averageCarPower = 0;
            }
            Console.WriteLine($"Cars have average horsepower of: {averageCarPower:f2}.");

            var trucks = vehicles.FindAll(truck => truck.Type == "truck");
            var truckPower = trucks.Sum(t => t.HorsePower);
            var averageTruckPower = truckPower / trucks.Count;
            if (trucks.Count == 0)
            {
                averageTruckPower = 0;
            }
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckPower:f2}.");

        }
    }

    public class Vehicle
    {
        public Vehicle(string type, string model, string color, double horsepower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsepower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (this.Type == "car")
            {
                stringBuilder.AppendLine($"Type: Car");
            }
            else
            {
                stringBuilder.AppendLine($"Type: Truck");
            }
            
            stringBuilder.AppendLine($"Model: {this.Model}");
            stringBuilder.AppendLine($"Color: {this.Color}");
            stringBuilder.AppendLine($"Horsepower: {this.HorsePower}");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
