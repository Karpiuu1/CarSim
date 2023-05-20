using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator.Models
{
    internal class Engine
    {
        public string Nazwa { get; set; }
        public double Pojemnosc { get; set; }
        public double Spalanie { get; set; }

        public Engine(string nazwa, double pojemnosc, double spalanie)
        {
            Nazwa = nazwa;
            Pojemnosc = pojemnosc;
            Spalanie = spalanie;
        }

    }
}
