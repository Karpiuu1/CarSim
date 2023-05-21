using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using CarSimulator.Models;
using CarSimulator.Services;

namespace CarSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine1 = new Engine("Engine 1", 2.0, "123456", 200, 10.0);
            Engine engine2 = new Engine("Engine 2", 3.0, "789123", 250, 8.5);
            Engine engine3 = new Engine("Engine 3", 2.5, "345678", 220, 9.5);

            Fueltank tank1 = new Fueltank(50.0);
            Fueltank tank2 = new Fueltank(60.0);
            Fueltank tank3 = new Fueltank(70.0);

            Tires tires1 = new Tires("Tires 1", 18.0, 225.0);
            Tires tires2 = new Tires("Tires 2", 19.0, 235.0);
            Tires tires3 = new Tires("Tires 3", 17.0, 215.0);

            Console.WriteLine("Available engines:");
            Console.WriteLine("1. Engine 1 - Capacity: " + engine1.Capacity + "L, Horsepower: " + engine1.Horsepower);
            Console.WriteLine("2. Engine 2 - Capacity: " + engine2.Capacity + "L, Horsepower: " + engine2.Horsepower);
            Console.WriteLine("3. Engine 3 - Capacity: " + engine2.Capacity + "L, Horsepower: " + engine3.Horsepower);

            Console.WriteLine("Select an engine (1-3):");
            int engineChoice = Convert.ToInt32(Console.ReadLine());
            Engine selectedEngine;

            switch (engineChoice)
            {
                case 1:
                    selectedEngine = engine1;
                    break;
                case 2:
                    selectedEngine = engine2; 
                    break;
                case 3:
                    selectedEngine = engine3;
                    break;
                default:
                    Console.WriteLine("Invalid engine choice. Exiting program.");
                    return;
            }
        }
       
    }
}
