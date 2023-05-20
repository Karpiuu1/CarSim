using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarSimulator.Models;

namespace CarSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine silnik1 = new Engine("BMW N63B44", 4398, 10.4);
            Engine silnik2 = new Engine("Toyota 2JZ", 2952, 10.1);
            Engine silnik3 = new Engine("Ford Mustang 5.0 TiVC", 7015, 21.5);

            Console.WriteLine("Witaj w konfiguratorze swojego samochodu, wybierz kolejno elementy składowe pojazdu, a następnie go przetestuj.");
            Console.WriteLine("Dostępne silniki:");
            Console.WriteLine("1. " + silnik1.Nazwa);
            Console.WriteLine("2. " + silnik2.Nazwa);
            Console.WriteLine("3. " + silnik3.Nazwa);

            Console.WriteLine("Wybierz, który silnik chcesz zamontowac do pojazdu (1-3):");
            int wybor = Convert.ToInt32(Console.ReadLine());

            Engine wybranySilnik;
            switch (wybor)
            {
                case 1:
                    wybranySilnik = silnik1;
                    break;
                case 2:
                    wybranySilnik = silnik2;
                    break;
                case 3:
                    wybranySilnik = silnik3;
                    break;
                default:
                    Console.WriteLine("Nieprawidłowo wybrany silnik, należy wskazać pozycje od 1 do 3");
                    return;
            }
            Console.WriteLine("Wybrano silnik:", wybranySilnik.Nazwa);
            Console.WriteLine("Pojemność silnika:" + wybranySilnik.Pojemnosc + " cm3");
            Console.WriteLine("Śrendie spalanie silnika:" + wybranySilnik.Spalanie + " L/100km");
        }
    }
}
