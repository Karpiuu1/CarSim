using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator.Models
{
    public class Fueltank
    {
        public double MaxCapacity { get; set; }
        public double CurrentLevel { get; set; }
        public Fueltank (double maxCapacity)
        {
            MaxCapacity = maxCapacity;
            CurrentLevel = maxCapacity;
        }
    }
}
