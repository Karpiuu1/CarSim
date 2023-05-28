using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using CarSimulator.Models;

namespace CarSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine1 = new Engine("Ford EcoBoost", 2.0, "WFAAX028125IS", 200, 10.0);
            Engine engine2 = new Engine("BMW N53B30", 3.0, "WBANA202B294712", 250, 8.5);
            Engine engine3 = new Engine("Mercedes M270", 2.5, "XZ425SDX2394255", 220, 9.5);

            Fueltank tank1 = new Fueltank(50.0);
            Fueltank tank2 = new Fueltank(60.0);
            Fueltank tank3 = new Fueltank(70.0);

            Tires tires1 = new Tires("18' BBS", 18.0, 225.0);
            Tires tires2 = new Tires("19' JapanRacing", 19.0, 235.0);
            Tires tires3 = new Tires("17' AEZ", 17.0, 215.0);

            Console.WriteLine("Available engines:");
            Console.WriteLine("1. Ford EcoBoost - Capacity: " + engine1.Capacity + "L, Horsepower: " + engine1.Horsepower);
            Console.WriteLine("2. BMW N53B30 - Capacity: " + engine2.Capacity + "L, Horsepower: " + engine2.Horsepower);
            Console.WriteLine("3. Mercedes M270 - Capacity: " + engine2.Capacity + "L, Horsepower: " + engine3.Horsepower);

            Console.WriteLine("Select an engine (1-3):");
            int engineChoice = Convert.ToInt32(Console.ReadLine());
            Engine selectedEngine;
            System.Threading.Thread.Sleep(500);
            Console.Clear();

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
            Console.WriteLine("1. Fueltank 1 - Max Capacity: " + tank1.MaxCapacity + "L");
            Console.WriteLine("2. Fueltank 2 - Max Capacity: " + tank2.MaxCapacity + "L");
            Console.WriteLine("3. Fueltank 3 - Max Capacity: " + tank3.MaxCapacity + "L");

            Console.WriteLine("Select a fuel tank (1-3): ");
            int tankChoice = Convert.ToInt32(Console.ReadLine());
            Fueltank selectedTank;

            System.Threading.Thread.Sleep(500);
            Console.Clear();

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
            Console.WriteLine("1. 18' BBS - Size: " + tires1.Size + ", Width " + tires1.Width);
            Console.WriteLine("2. 19' JapanRacing - Size: " + tires2.Size + ", Width " + tires2.Width);
            Console.WriteLine("3. 17' AEZ - Size: " + tires3.Size + ", WIdth " + tires3.Width);

            Console.WriteLine("Select tires (1-3):");
            int tiresChoice = Convert.ToInt32(Console.ReadLine());
            Tires selectedTires;

            System.Threading.Thread.Sleep(500);
            Console.Clear();

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

            System.Threading.Thread.Sleep(500);
            Console.Clear();

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
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ");
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
                        Console.Clear();
                        Console.WriteLine("Driving...");
                        System.Threading.Thread.Sleep(2500);
                        isDriving = true;
                        DriveCar(selectedEngine, selectedTank);
                        isDriving = false;

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Select a new engine:");
                        Console.WriteLine("1. Ford EcoBoost - Mileage: " + engine1.Mileage + "km");
                        Console.WriteLine("2. BMW N53B30 - Mileage: " + engine2.Mileage + "km");
                        Console.WriteLine("3. Mercedes M270 - Mileage: " + engine3.Mileage + "km");
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
                        Console.Clear();
                        Console.WriteLine("Choice what would you like to do now:");
                        Console.WriteLine("1. Drive");
                        Console.WriteLine("2. Change engine");
                        Console.WriteLine("3. Refuel");
                        Console.WriteLine("4. Car status");
                        Console.WriteLine("5. Exit program");


                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Enter fuel amount to refuel:");
                        double refuelAmount = Convert.ToDouble(Console.ReadLine());
                        
                        if (refuelAmount > selectedTank.MaxCapacity)
                        {
                            Console.WriteLine($"{refuelAmount} liters is way to much, maximum capacity is {selectedTank.MaxCapacity} liters");
                            System.Threading.Thread.Sleep(3000);
                            Console.Clear();
                        }
                        else
                        {
                            selectedTank.CurrentLevel += refuelAmount;
                            Console.WriteLine("Fuel tank is refueled by " + refuelAmount + " liters");
                            System.Threading.Thread.Sleep(2500);
                            Console.Clear();
                        }

                        Console.WriteLine("Choice what would you like to do now:");
                        Console.WriteLine("1. Drive");
                        Console.WriteLine("2. Change engine");
                        Console.WriteLine("3. Refuel");
                        Console.WriteLine("4. Car status");
                        Console.WriteLine("5. Exit program");

                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Current car status:");
                        Console.WriteLine("Color " + selectedColor);
                        Console.WriteLine("Engine " + selectedEngine.Name);
                        Console.WriteLine("Fuel tank capacity: " + selectedTank.MaxCapacity + "L");
                        Console.WriteLine("Acutual fuel tank level: " + selectedTank.CurrentLevel + "L");
                        Console.WriteLine("Tires: " + selectedTires.Name);
                        Console.WriteLine("Mileage: " + selectedEngine.Mileage + "km");
                        Console.WriteLine("Press any button to get back to main menu");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Choice what would you like to do now:");
                        Console.WriteLine("1. Drive");
                        Console.WriteLine("2. Change engine");
                        Console.WriteLine("3. Refuel");
                        Console.WriteLine("4. Car status");
                        Console.WriteLine("5. Exit program");
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
            double fuelCapacity = tank.CurrentLevel;
            int fuelUsed = 0;
            string fuelBar = new string('#', (int)fuelCapacity);
            Console.WriteLine($"[{fuelBar}] Actual fuel status");

            while (tank.CurrentLevel > 0 && distance > 0)
            {
               
                double fuelConsumed = engine.AvarageFuelConsumption * distance;
                if (fuelConsumed > tank.CurrentLevel)
                {
                    fuelConsumed = tank.CurrentLevel;
                }

                engine.ConsumeFuel(fuelConsumed);
                tank.CurrentLevel -= fuelConsumed;
                // distance += engine.Mileage; //++; //fuelConsumed / engine.AvarageFuelConsumption;
                while(fuelUsed < fuelCapacity)
                {
                    fuelUsed++;
                    fuelBar = fuelBar.Substring(0, (int)fuelCapacity - fuelUsed) + "-" + fuelBar.Substring((int)fuelCapacity - fuelUsed + 1);
                    Console.Clear();
                    Console.WriteLine($"[{fuelBar}] Actual fuel status");
                    System.Threading.Thread.Sleep(100);
                }
                Console.WriteLine("Car stopped. Out of fuel - fueltank is empty");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Driving... Distance passed: " + distance + "km");
                // Time passing simulation (5 seconds delay between each travaled distance
                System.Threading.Thread.Sleep(1000);

            }
            
            
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("Choice what would you like to do now:");
            Console.WriteLine("1. Drive");
            Console.WriteLine("2. Change engine");
            Console.WriteLine("3. Refuel");
            Console.WriteLine("4. Car status");
            Console.WriteLine("5. Exit program");
        }


    }
}
