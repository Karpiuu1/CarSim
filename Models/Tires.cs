using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator.Models
{
    public class Tires
    {
        public string Name { get; set; }
        public double Size { get; set; }
        public double Width { get; set; }

        public Tires (string name, double size, double width)
        {
            Name = name;
            Size = size;
            Width = width;
        }
    }
}
