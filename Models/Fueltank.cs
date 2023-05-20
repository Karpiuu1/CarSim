using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator.Models
{
    public class Fueltank
    {
        private const int Capacity = 80;
        private int currentFuel;

        public Fueltank()
        {
            currentFuel = 0;
        }
    }
}
