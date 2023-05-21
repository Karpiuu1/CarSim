using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator.Models
{
    class Engine
    {
        public string Name { get; set; }
        public double Capacity { get; set; }
        public string SerialNumber { get; set; }
        public int Horsepower { get; set; }
        public double AvarageFuelConsumption { get; set; }
        public double Mileage { get; private set; }

        public Engine(string name, double capacity, string serialNumber, int horsepower, double avarageFuelConsumption)
        {
            Name = name;
            Capacity = capacity;
            SerialNumber = serialNumber;
            Horsepower = horsepower;
            AvarageFuelConsumption = avarageFuelConsumption;
            Mileage = 0;
        }
        public void ConsumeFuel (double fuelAmount)
        {
            if (fuelAmount < 0)
            {
                throw new ArgumentException("Fuel amount cannot be negative.");
            }
            double distance = fuelAmount / AvarageFuelConsumption * 100;
            Mileage += distance;
        }
    }
}
