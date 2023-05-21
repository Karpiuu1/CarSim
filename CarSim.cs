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
            Console.WriteLine("Available fuel tanks: ");
            Console.WriteLine("1. Tank 1 - Max Capacity: " + tank1.MaxCapacity + "L");
            Console.WriteLine("2. Tank 2 - Max Capacity: " + tank2.MaxCapacity + "L");
            Console.WriteLine("3. Tank 3 - Max Capacity: " + tank3.MaxCapacity + "L");

            Console.WriteLine("Select a fuel tank (1-3): ");
            int tankChoice = Convert.ToInt32(Console.ReadLine());
            Fueltank selectedTank;
            switch (tankChoice)
            {
                case 1:
                    selectedTank = tank1;
                    break;
                case 2:
                    selectedTank = tank2;
                    break;
                case 3:
                    selectedTank = tank3;
                    break;
                default:
                    Console.WriteLine("Invalid tank choice. Exiting program");
                    return;
            }
            Console.WriteLine("Available tires:");
            Console.WriteLine("1. Tires 1 - Size: " + tires1.Size + ", Width" + tires1.Width);
            Console.WriteLine("2. Tires 2 - Size: " + tires2.Size + ", Width" + tires2.Width);
            Console.WriteLine("3. Tires 3 - Size: " + tires3.Size + ", WIdth" + tires3.Width);

            Console.WriteLine("Select tires (1-3):");
            int tiresChoice = Convert.ToInt32(Console.ReadLine());
            Tires selectedTires;

            switch (tiresChoice)
            {
                case 1:
                    selectedTires = tires1;
                    break;
                case 2:
                    selectedTires = tires2;
                    break;
                case 3:
                    selectedTires = tires3;
                    break;
                default:
                    Console.WriteLine("Invalid tires choice. Exiting program.");
                    return;

            }
            Console.WriteLine("Available colors:");
            Console.WriteLine("1. Red");
            Console.WriteLine("2. Blue");
            Console.WriteLine("3. Green");
            Console.WriteLine("4. Black");
            Console.WriteLine("5. White");

            Console.WriteLine("Select a car color (1-5)");
            int colorChoice = Convert.ToInt32(Console.ReadLine());
            Colors selectedColor;

            switch (colorChoice)
            {
                case 1:
                    selectedColor = Colors.Red;
                    break;
                case 2:
                    selectedColor = Colors.Green;
                    break;
                case 3:
                    selectedColor = Colors.Blue;
                    break;
                case 4:
                    selectedColor = Colors.Black;
                    break;
                case 5:
                    selectedColor = Colors.White;
                    break;
                default:
                    Console.WriteLine("Invalid color selection. Exiting program");
                    return;

            }

            Console.WriteLine("Your car configuration:");
            Console.WriteLine("Engine: " + selectedEngine.Name);
            Console.WriteLine("Fuel tank capacity: " + selectedTank.MaxCapacity + "L");
            Console.WriteLine("Tires: " + selectedTires.Name + " " + selectedTires.Width + "  " + selectedTires.Size);
            Console.WriteLine("Color: " + selectedColor);
            System.Threading.Thread.Sleep(2500);
            Console.Clear();

            Console.WriteLine("Choice what would you like to do now:");
            Console.WriteLine("1. Drive");
            Console.WriteLine("2. Change engine");
            Console.WriteLine("3. Refuel");
            Console.WriteLine("4. Car status");
            Console.WriteLine("5. Exit program");

            int menuChoice;
            bool isDriving = false;
            do
            {

                menuChoice = Convert.ToInt32(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1:
                        if (isDriving)
                        {
                            Console.WriteLine("Car is already driving");
                            continue;
                        }
                        Console.WriteLine("Driving...");
                        isDriving = true;
                        DriveCar(selectedEngine, selectedTank);
                        isDriving = false;
                  
                        break;
                    case 2:
                        Console.WriteLine("Select a new engine:");
                        Console.WriteLine("1. Engine 1 - Mileage: " + engine1.Mileage + "km");
                        Console.WriteLine("2. Engine 2 - Mileage: " + engine2.Mileage + "km");
                        Console.WriteLine("3. Engine 3 - Mileage: " + engine3.Mileage + "km");
                        int newEngineChoice = Convert.ToInt32(Console.ReadLine());

                        Engine newEngine;
                        switch (newEngineChoice)
                        {
                            case 1:
                                newEngine = engine1;
                                break;
                            case 2:
                                newEngine = engine2;
                                break;
                            case 3:
                                newEngine = engine3;
                                break;
                            default:
                                Console.WriteLine("Invalid engine choice. Exiting program");
                                return;
                        }
                        selectedEngine = newEngine;
                        Console.WriteLine("Engine changed to: " + selectedEngine.Name);
                        System.Threading.Thread.Sleep(2500);
                        
                        break;
                    case 3:
                        Console.WriteLine("Enter fuel amount to refuel:");
                        double refuelAmount = Convert.ToDouble(Console.ReadLine());
                        selectedTank.CurrentLevel += refuelAmount;
                        Console.WriteLine("Fuel tank is refueled by " + refuelAmount + "liters");
                        System.Threading.Thread.Sleep(2500);
                    
                        break;
                    case 4:
                        Console.WriteLine("Current car status:");
                        Console.WriteLine("Color " + selectedColor);
                        Console.WriteLine("Engine " + selectedEngine.Name);
                        Console.WriteLine("Fuel tank capacity: " + selectedTank.MaxCapacity + "L");
                        Console.WriteLine("Acutual fuel tank level: " + selectedTank.CurrentLevel + "L");
                        Console.WriteLine("Tires: " + selectedTires.Name);
                        Console.WriteLine("Mileage: " + selectedEngine.Mileage + "km");
                        break;
                    case 5:
                        Console.WriteLine("Exiting program.");
                        
                        break;
                    default:
                        Console.WriteLine("Invalid menu choice");
                        
                        break;
                        
                    
                }
            } while (menuChoice != 5);
            
        }
        static void DriveCar(Engine engine, Fueltank tank)
        {
            double distance = tank.CurrentLevel / engine.AvarageFuelConsumption * 100; // constant distance to drive in kilometers

            while (tank.CurrentLevel > 0 && distance > 0)
            {
                double fuelConsumed = engine.AvarageFuelConsumption * distance;
                if (fuelConsumed > tank.CurrentLevel)
                {
                    fuelConsumed = tank.CurrentLevel;
                }

                engine.ConsumeFuel(fuelConsumed);
                tank.CurrentLevel -= fuelConsumed;
                distance ++; //fuelConsumed / engine.AvarageFuelConsumption;

                Console.WriteLine("Driving... Distance passed: " + distance + "km");
                // Time passing simulation (5 seconds delay between each travaled distance
                System.Threading.Thread.Sleep(5000);
            }

            Console.WriteLine("Car stopped. Out of fuel.");
            Console.WriteLine("Choice what would you like to do now:");
            Console.WriteLine("1. Drive");
            Console.WriteLine("2. Change engine");
            Console.WriteLine("3. Refuel");
            Console.WriteLine("4. Car status");
            Console.WriteLine("5. Exit program");
        }


    }
}
